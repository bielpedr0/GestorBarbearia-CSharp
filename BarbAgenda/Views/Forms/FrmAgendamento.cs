using BarbAgenda.Infrastructure;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using BarbAgenda.Models.Exibicao;
using System.Data;

namespace BarbAgenda.Views
{
    public partial class FrmAgendamento : Form
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        private readonly AgendamentoRepository agendamentoRepository;
        private readonly ClienteRepository clienteRepository;
        private readonly ServicoRepository servicoRepository;

        public FrmAgendamento(BarbAgendaDbContext barbAgendaDbContext)
        {
            InitializeComponent();
            ConfiguracaoMascaraCampos();
            _barbAgendaDbContext = barbAgendaDbContext;
            clienteRepository = new ClienteRepository(barbAgendaDbContext);
            servicoRepository = new ServicoRepository(barbAgendaDbContext);
            agendamentoRepository = new AgendamentoRepository(barbAgendaDbContext, clienteRepository, servicoRepository);

            /* Image image = Image.FromFile("C:\\Users\\Usuario\\OneDrive\\Área de Trabalho\\testeTrabalho\\WindowsFormsApp1\\Resources\\Agenda-PainelFundo.png");

             // Definindo a cor de fundo do PictureBox como a cor que você deseja tornar transparente
             formularioImg.BackColor = Color.Transparent;

             // Evento Paint do PictureBox
             formularioImg.Paint += (s, args) =>
             {
                 // Desenha a imagem com partes transparentes no PictureBox
                 args.Graphics.DrawImage(image, new Rectangle(Point.Empty, formularioImg.Size));
             };*/
        }

        private void ConfiguracaoMascaraCampos()
        {
            // Configurar a máscara de data no construtor ou no método Load do formulário
            maskedTextBoxData.Mask = "00/00/0000"; // Defina a máscara desejada
            maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            maskedTextBoxTime.Mask = "00:00"; // Defina a máscara desejada
            maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            // Preencher ComboBox de Clientes
            List<Tuple<int, string>> nomesClientes = clienteRepository.ObterNomesClientes();
            comboBoxCliente.DisplayMember = "Item2";
            comboBoxCliente.ValueMember = "Item1";
            comboBoxCliente.DataSource = nomesClientes;

            // Preencher ComboBox de Serviços
            List<string> nomesServicos = servicoRepository.ObterNomesServicos();
            comboBoxServico.DataSource = nomesServicos;

            // Adicionar o evento SelectedIndexChanged ao ComboBox de Serviços
            comboBoxServico.SelectedIndexChanged += comboBoxServico_SelectedIndexChanged;

            // Mostrar o valor do serviço inicialmente selecionado
            if (comboBoxServico.SelectedItem != null)
            {
                string servicoSelecionado = comboBoxServico.GetItemText(comboBoxServico.SelectedItem);
                decimal valorServico = servicoRepository.GetValueByName(servicoSelecionado);
                txbValor.Text = valorServico.ToString("C");
            }
            AtualizarGridAgendamentos();
        }


        private void comboBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtem o valor selecionado do ComboBox convertendo para string
            string nomeServicoSelecionado = comboBoxServico.GetItemText(comboBoxServico.SelectedItem);

            // Verifica se o valor não é nulo ou vazio antes de prosseguir
            if (!string.IsNullOrEmpty(nomeServicoSelecionado))
            {
                // Obter o valor do serviço e exibir na TextBox
                decimal valorServico = servicoRepository.GetValueByName(nomeServicoSelecionado);
                txbValor.Text = valorServico.ToString("C");
            }
        }

        public void AtualizarComboBoxClientes()
        {
            List<Tuple<int, string>> nomesClientes = clienteRepository.ObterNomesClientes();
            comboBoxCliente.DisplayMember = "Item2";
            comboBoxCliente.ValueMember = "Item1";
            comboBoxCliente.DataSource = nomesClientes;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // Obter os valores selecionados nos ComboBoxes e TextBoxes
            int idCliente = (int)comboBoxCliente.SelectedValue;
            string servicoSelecionado = comboBoxServico.SelectedItem.ToString();
            DateTime dataAtendimento = DateTime.Parse(maskedTextBoxData.Text);
            DateTime horario = DateTime.Parse(maskedTextBoxTime.Text);
            DateTime dataEHorario = new DateTime(dataAtendimento.Year, dataAtendimento.Month, dataAtendimento.Day, horario.Hour, horario.Minute, horario.Second);

            // Obter o ID do serviço selecionado
            int idServico = servicoRepository.GetIdByName(servicoSelecionado); // Implemente essa função na sua lógica

            // Agendar
            bool agendado = agendamentoRepository.Agendar(idCliente, idServico, dataAtendimento, dataEHorario);
            if (agendado)
            {
                MessageBox.Show("Agendamento realizado com sucesso!");
                // Atualizar o DataGridView com os novos dados
                AtualizarGridAgendamentos();
            }
            else
            {
                MessageBox.Show("Falha ao agendar!");
            }
        }

        private void AtualizarGridAgendamentos()
        {
            List<Agendamento> agendamentos = agendamentoRepository.ObterAgendamentos();
            List<AgendamentoExibicao> agendamentosExibicao = new List<AgendamentoExibicao>();

            foreach (var agendamento in agendamentos)
            {
                agendamentosExibicao.Add(new AgendamentoExibicao
                {
                    Id = agendamento.Id,
                    NomeCliente = agendamento.Cliente.Nome,
                    NomeServico = agendamento.Servico.Nome,
                    DataAtendimento = agendamento.DataAtendimento,
                    Horario = agendamento.Horario
                });
            }

            DataTable dataTable = new DataTable();

            dataTable.Clear();

            if (!dataTable.Columns.Contains("Id"))
            {
                dataTable.Columns.Add("Id");
            }
            if (!dataTable.Columns.Contains("Nome Cliente"))
            {
                dataTable.Columns.Add("Nome Cliente");
            }
            if (!dataTable.Columns.Contains("Nome Serviço"))
            {
                dataTable.Columns.Add("Nome Serviço");
            }
            if (!dataTable.Columns.Contains("Data Atendimento"))
            {
                dataTable.Columns.Add("Data Atendimento");
            }
            if (!dataTable.Columns.Contains("Horario Atendimento"))
            {
                dataTable.Columns.Add("Horario Atendimento");
            }

            if (agendamentosExibicao is not null && agendamentosExibicao.Count > 0)
            {
                // Itera sobre a lista e adiciona os dados à tabela
                foreach (var agendamentoExibicao in agendamentosExibicao)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = agendamentoExibicao.Id;
                    row["Nome Cliente"] = agendamentoExibicao.NomeCliente;
                    row["Nome Serviço"] = agendamentoExibicao.NomeServico;
                    row["Data Atendimento"] = agendamentoExibicao.DataAtendimento.ToString("dd/MM/yyyy");
                    row["Horario Atendimento"] = agendamentoExibicao.Horario.ToString("HH:mm");
                    dataTable.Rows.Add(row);
                }
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verificar se alguma linha está selecionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Capturar o índice da linha selecionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obter o objeto de agendamento associado a essa linha
                int agendamentoId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);

                if (agendamentoId > 0)
                {
                    // Excluir o agendamento do banco de dados usando a instância do repositório
                    bool excluido = agendamentoRepository.ExcluirAgendamento(agendamentoId);

                    if (excluido)
                    {
                        MessageBox.Show("Agendamento excluído com sucesso!");
                        // Atualizar o DataGridView para refletir a exclusão
                        AtualizarGridAgendamentos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o agendamento!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para excluir.");
            }
        }        
    }
}
