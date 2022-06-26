namespace SinafApi.Domain.Models
{
    public class Endereco
    {
        public Guid IdEndereco { get; set; }
        public Guid IdCliente { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
