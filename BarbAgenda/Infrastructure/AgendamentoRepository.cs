using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using Microsoft.EntityFrameworkCore;

namespace BarbAgenda.Infrastructure
{
    public class AgendamentoRepository
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        private readonly ClienteRepository _clienteRepository;
        private readonly ServicoRepository _servicoRepository;

        public class AgendamentoViewModel
        {
            public string ClienteNome { get; set; }
            public string ServicoNome { get; set; }
            public string Horario { get; set; }
        }
        public AgendamentoRepository(
            BarbAgendaDbContext barbAgendaDbContext,
            ClienteRepository clienteRepository, 
            ServicoRepository servicoRepository)
        {
            _barbAgendaDbContext = barbAgendaDbContext;
            _clienteRepository = clienteRepository;
            _servicoRepository = servicoRepository;
        }
        
        public bool Agendar(int idCliente, int idServico, DateTime dataAtendimento, DateTime horario)
        {
            var cliente = _clienteRepository.GetById(idCliente);
            var servico = _servicoRepository.GetById(idServico);

            if (cliente == null || servico == null)
                return false;

            //Pensar em como validar data
            //Sugestão: Validar se já existe um agendamento para a data e horario informado

            var agendamento = new Agendamento
            {
                DataAtendimento = dataAtendimento,
                Horario = horario,
                Cliente = cliente,
                Servico = servico
            };

            _barbAgendaDbContext.Add(agendamento);
            _barbAgendaDbContext.SaveChanges();

            return true;
        }

        public List<Agendamento> ObterAgendamentos()
        {            
            return _barbAgendaDbContext.Agendamentos
                .Include(agendamento => agendamento.Cliente)
                .Include(agendamento => agendamento.Servico)
                .ToList();
        }

        public bool ExcluirAgendamento(int agendamentoId)
        {            
            var agendamento = _barbAgendaDbContext.Agendamentos
                .Where(agendamento => agendamento.Id == agendamentoId)
                .FirstOrDefault();

            if (agendamento is null)
            {
                return false;
            }
            
            _barbAgendaDbContext.Agendamentos.Remove(agendamento);
            _barbAgendaDbContext.SaveChanges();
            return true;                        
        }


        public List<Agendamento> ObterAgendamentosPorDia(DateTime date)
        {            
            List<Agendamento> agendamentosDoDia = _barbAgendaDbContext.Agendamentos
                .Where(a => a.DataAtendimento.Date == date)
                .Include(a => a.Cliente)
                .Include(a => a.Servico)
                .ToList();

            return agendamentosDoDia;
        }

        public List<Agendamento> ObterAgendamentoIntervaloData(DateTime dataInicial, DateTime dataFinal)
        {
            var agendamentos = _barbAgendaDbContext.Agendamentos
                .Where(agendamento => 
                    agendamento.DataAtendimento >= dataInicial && 
                    agendamento.DataAtendimento <= dataFinal)
                .Include(x => x.Cliente)
                .Include(x => x.Servico)
                .ToList();

            return agendamentos;
        }
    }
}
