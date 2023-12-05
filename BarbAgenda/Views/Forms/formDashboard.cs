using BarbAgenda.Infrastructure;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using BarbAgenda.Models.Exibicao;
using System.Data;
using System.Globalization;

namespace BarbAgenda.Views
{
    public partial class formDashboard : Form
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        private readonly ClienteRepository clienteRepository;
        private readonly ServicoRepository servicoRepository;
        private readonly AgendamentoRepository agendamentoRepository;
        
        public formDashboard(BarbAgendaDbContext barbAgendaDbContext)
        {
            InitializeComponent();
            ConfiguracaoMascaraCampos();
            _barbAgendaDbContext = barbAgendaDbContext;
            clienteRepository = new ClienteRepository(barbAgendaDbContext);
            servicoRepository = new ServicoRepository(barbAgendaDbContext);
            agendamentoRepository = new AgendamentoRepository(barbAgendaDbContext, clienteRepository, servicoRepository);
        }        

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }        

        private void ConfiguracaoMascaraCampos()
        {
            // Configurar a máscara de data no construtor ou no método Load do formulário
            maskedTextBoxDataInicial.Mask = "00/00/0000"; // Defina a máscara desejada
            maskedTextBoxDataInicial.ValidatingType = typeof(System.DateTime);
            maskedTextBoxDataFinal.Mask = "00/00/0000"; // Defina a máscara desejada
            maskedTextBoxDataFinal.ValidatingType = typeof(System.DateTime);            
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DateTime dataInicial;
            DateTime dataFinal;

            // Array de formatos possíveis para a data
            string[] formatosData = { "dd/MM/yyyy" };

            var dataInicialValida = DateTime.TryParseExact(maskedTextBoxDataInicial.Text, formatosData, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataInicial);
            var dataFinalValida = DateTime.TryParseExact(maskedTextBoxDataFinal.Text, formatosData, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataFinal);

            if (dataInicialValida == false || dataFinalValida == false)
            {
                MessageBox.Show("Insira uma data válida para data inicial e data final");
            }            

            var agendamentos = agendamentoRepository.ObterAgendamentoIntervaloData(dataInicial, dataFinal);

            CarregarRelatorioNaGrid(agendamentos);
            DefinirPrecoTotal(agendamentos);
        }

        private void DefinirPrecoTotal(List<Agendamento> agendamentos)
        {
            var precoTotalPeriodo = agendamentos.Sum(x => x.Servico.Preco);
            labelValorTotal.Text = $"Valor total R${Math.Round(precoTotalPeriodo, 2)}";
        }

        private void CarregarRelatorioNaGrid(List<Agendamento> agendamentos)
        {
            List<AgendamentoExibicao> agendamentosExibicao = new List<AgendamentoExibicao>();

            foreach (var agendamento in agendamentos)
            {
                agendamentosExibicao.Add(new AgendamentoExibicao
                {
                    Id = agendamento.Id,
                    NomeCliente = agendamento.Cliente.Nome,
                    NomeServico = agendamento.Servico.Nome,
                    PrecoServico = agendamento.Servico.Preco,
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
            if (!dataTable.Columns.Contains("Preço Serviço"))
            {
                dataTable.Columns.Add("Preço Serviço");
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
                    row["Preço Serviço"] = Math.Round(agendamentoExibicao.PrecoServico, 2);
                    row["Data Atendimento"] = agendamentoExibicao.DataAtendimento.ToString("dd/MM/yyyy"); ;
                    row["Horario Atendimento"] = agendamentoExibicao.Horario.ToString("HH:mm");
                    dataTable.Rows.Add(row);
                }
            }

            dataGridViewRelatorioAgendamento.DataSource = dataTable;
            dataGridViewRelatorioAgendamento.Columns["Id"].Visible = false;
        }
    }
}
