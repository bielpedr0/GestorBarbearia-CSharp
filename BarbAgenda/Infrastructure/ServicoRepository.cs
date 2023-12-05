using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;

namespace BarbAgenda.Infrastructure
{
    public class ServicoRepository
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        public ServicoRepository(BarbAgendaDbContext barbAgendaDbContext)
        {
            _barbAgendaDbContext = barbAgendaDbContext;
        }

        public List<string> ObterNomesServicos()
        {
            var result = _barbAgendaDbContext.Servicos.Select(x => x.Nome);
            return result.ToList();
        }

        public Servico GetById(int id)
        {
            var servico = _barbAgendaDbContext.Servicos
                .Where(servico => servico.Id == id)
                .FirstOrDefault();

            return servico;
        }

        public decimal GetValueByName(string name)
        {
            var value = _barbAgendaDbContext.Servicos
                .Where(servico => servico.Nome == name)
                .Select(x => x.Preco)
                .FirstOrDefault();

            return value;
        }

        public int GetIdByName(string name)
        {
            var id = _barbAgendaDbContext.Servicos
                .Where(servico => servico.Nome == name)
                .Select(x => x.Id)
                .FirstOrDefault();

            if (id <= 0)
                return 0;

            return id;
        }
    }
}
