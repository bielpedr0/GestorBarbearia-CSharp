using BarbAgenda.Models;
using Microsoft.EntityFrameworkCore;

namespace BarbAgenda.Infrastructure.Contexts
{
    public class BarbAgendaDbContext : DbContext
    {
        public BarbAgendaDbContext()
        : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Server=localhost;User Id=root;Password=159482;Database=barb-calendario;";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
