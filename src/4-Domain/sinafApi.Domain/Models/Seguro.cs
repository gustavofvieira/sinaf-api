using System;

namespace SinafApi.Domain.Models
{
    public class Seguro
    {
        public Guid IdSeguro { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ImportanciaAssegurada { get; set; }
        public double Percentual { get; set; }
        public double PremioCobertura { get; set; }
        public string NomeCorretor { get; set; }
    }
}
