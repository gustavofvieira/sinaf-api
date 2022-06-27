using System;
using System.Collections.Generic;
using SinafApi.Domain.Enums;

namespace SinafApi.Domain.Models
{
    public class Cliente
    {
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public Sexo Sexo { get; set; }   
        public List<Endereco> Enderecos { get; set; }    
    }
}
