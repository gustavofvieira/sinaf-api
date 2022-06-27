using SinafApi.Domain.Models;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface IClienteService : IBaseService<Cliente>
    {
       
        void Cadastrar(Cliente cliente);
    }
}
