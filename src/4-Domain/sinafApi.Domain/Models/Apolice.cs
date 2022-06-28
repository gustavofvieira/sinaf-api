using SinafApi.Domain.Enums;
using System;

namespace SinafApi.Domain.Models
{
    public class Apolice
    {
        public Guid IdApolice { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdSeguro { get; set; }
        public StatusApolice Status { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
