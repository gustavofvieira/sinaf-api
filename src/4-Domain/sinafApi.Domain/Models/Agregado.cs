using System;

namespace SinafApi.Domain.Models
{
    public class Agregado
    {
        public Guid IdAgregado { get; set; }
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
    }
}
