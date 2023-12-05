using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbAgenda.Models.Exibicao
{
    public class AgendamentoExibicao
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string NomeServico { get; set; }
        public decimal PrecoServico { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime Horario { get; set; }
    }
}
