using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity;

namespace BarbAgenda.Infrastructure
{
    public class ClienteRepository
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        public ClienteRepository(BarbAgendaDbContext barbAgendaDbContext)
        {
            _barbAgendaDbContext = barbAgendaDbContext;
        }

        public void Add(Cliente cliente)
        {
            _barbAgendaDbContext.Add(cliente);
            _barbAgendaDbContext.SaveChanges();
        }

        public Cliente GetById(int id)
        {
            var cliente = _barbAgendaDbContext.Clientes
                .Where(cliente => cliente.Id == id)
                .FirstOrDefault();

            return cliente;
        }

        public Cliente GetByCpf(string cpf)
        {
            var cliente = _barbAgendaDbContext.Clientes
                .Where(cliente => cliente.Cpf == cpf)
                .FirstOrDefault();

            return cliente;
        }        

        //Remove a pessoa do cadastro que possuir um cpf igual ao passado como parâmetro.
        public bool RemoveByCpf(string cpf)
        {
            //procura um cliente que possua o cpf igual ao passado como parâmetro
            //caso encontre retorna uma referência para esse funcionário;
            //caso não encontre, retorna null
            Cliente cliente = GetByCpf(cpf);

            //verifica se cliente existe
            if (cliente is null)
            {
                return false;
                
            }

            _barbAgendaDbContext.Remove(cliente);
            _barbAgendaDbContext.SaveChanges();

            return true;
        }        

        public bool Update(Cliente cliente)
        {
            Cliente clienteToBeUpdated = GetByCpf(cliente.Cpf);

            if (clienteToBeUpdated is null)
            {
                return false;
            }

            clienteToBeUpdated.Nome = cliente.Nome;
            clienteToBeUpdated.Email = cliente.Email;
            clienteToBeUpdated.Telefone = cliente.Telefone;

            _barbAgendaDbContext.SaveChanges();
            return true;
        }        

        public void GerarRelatorioCliente(DataTable table)
        {
            //limpa qualquer dado anterior da tabela
            table.Clear();

            var clientes = _barbAgendaDbContext.Clientes.ToList();

            // Se o DataSource não for um DataTable, você pode criar um novo DataTable                
            if (!table.Columns.Contains("Nome"))
            {
                table.Columns.Add("Nome");
            }
            if (!table.Columns.Contains("Cpf"))
            {
                table.Columns.Add("Cpf");
            }
            if (!table.Columns.Contains("Telefone"))
            {
                table.Columns.Add("Telefone");
            }
            if (!table.Columns.Contains("Email"))
            {
                table.Columns.Add("Email");
            }
            //table.Columns.Add("Cpf");
            //table.Columns.Add("Telefone");
            //table.Columns.Add("Email");

            if (clientes is not null && clientes.Count > 0)
            {
                // Itera sobre a lista e adiciona os dados à tabela
                foreach (var cliente in clientes)
                {
                    DataRow row = table.NewRow();
                    row["Nome"] = cliente.Nome;
                    row["Cpf"] = cliente.Cpf;
                    row["Telefone"] = cliente.Telefone;
                    row["Email"] = cliente.Email;
                    table.Rows.Add(row);
                }
            }
        }
        
        public List<Tuple<int, string>> ObterNomesClientes()
        {
            List<Tuple<int, string>> nomesClientes = new List<Tuple<int, string>>();

            var result = _barbAgendaDbContext.Clientes.Select(x => new { id = x.Id, nome = x.Nome });
            
            foreach(var item in result)
            {
                nomesClientes.Add(new Tuple<int, string>(item.id, item.nome));
            }

            return nomesClientes;
        }
    }
}
