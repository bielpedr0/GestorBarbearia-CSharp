namespace BarbAgenda.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
