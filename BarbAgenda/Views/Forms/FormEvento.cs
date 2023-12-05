using BarbAgenda.Infrastructure;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using BarbAgenda.Models.Exibicao;
using BarbAgenda.Views.UCs;
using System.Data;
using System.Globalization;

namespace BarbAgenda.Views
{
    public partial class FormEvento : Form
    {
        private readonly AgendamentoRepository agendamentoRepository;

        public FormEvento(string day, BarbAgendaDbContext contexto)
        {
            InitializeComponent();            
            // Supondo que você precise passar instâncias de ClienteRepository e ServicoRepository
            ClienteRepository clienteRepository = new ClienteRepository(contexto);
            ServicoRepository servicoRepository = new ServicoRepository(contexto);
            agendamentoRepository = new AgendamentoRepository(contexto, clienteRepository, servicoRepository);
        }        

        private void FormEvento_Load(object sender, EventArgs e)
        {            
            // Assuming formCalendar.static_year, formCalendar.static_month, and UserControlDays.static_day are integers
            int year = formCalendar.static_year;
            int month = formCalendar.static_month;
            int day = Convert.ToInt32(UserControlDays.static_day);

            string dataSelecionadaText = new DateTime(year, month, day).ToString("dd/MM/yyyy");

            txbData.Text = dataSelecionadaText;

            // Obter agendamentos do dia selecionado usando o AgendamentoRepository
            DateTime dataSelecionada;
            string[] formatosData = { "dd/MM/yyyy" };

            var dataSelecionadaValida = DateTime.TryParseExact(dataSelecionadaText, formatosData, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataSelecionada);            

            if (!dataSelecionadaValida)
            {
                MessageBox.Show("Erro ao tentar converter data");
                return;
            }

            ExibirAgendamentosDoDia(dataSelecionada);
        }

        private void ExibirAgendamentosDoDia(DateTime dataSelecionada)
        {
            // Use o AgendamentoRepository para obter os agendamentos do dia
            List<Agendamento> agendamentos = agendamentoRepository.ObterAgendamentosPorDia(dataSelecionada);            
            
            List<AgendamentoExibicao> agendamentosExibicao = new List<AgendamentoExibicao>();

            foreach (var agendamento in agendamentos)
            {
                agendamentosExibicao.Add(new AgendamentoExibicao
                {                    
                    NomeCliente = agendamento.Cliente.Nome,
                    NomeServico = agendamento.Servico.Nome,
                    Horario = agendamento.Horario
                });
            }

            DataTable dataTable = new DataTable();

            dataTable.Clear();

            if (!dataTable.Columns.Contains("Nome Cliente"))
            {
                dataTable.Columns.Add("Nome Cliente");
            }
            if (!dataTable.Columns.Contains("Nome Serviço"))
            {
                dataTable.Columns.Add("Nome Serviço");
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
                    row["Nome Cliente"] = agendamentoExibicao.NomeCliente;
                    row["Nome Serviço"] = agendamentoExibicao.NomeServico;
                    row["Horario Atendimento"] = agendamentoExibicao.Horario.ToString("HH:mm");
                    dataTable.Rows.Add(row);
                }
            }

            // Atribua a lista de agendamentos ao seu controle de exibição (por exemplo, um DataGridView)
            dataGridViewCalendario.DataSource = dataTable;
        }
    }
}


