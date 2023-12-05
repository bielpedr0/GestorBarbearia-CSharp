namespace BarbAgenda.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime Horario { get; set; }
        public Cliente Cliente { get; set; }
        public Servico Servico { get; set; }
    }
}
