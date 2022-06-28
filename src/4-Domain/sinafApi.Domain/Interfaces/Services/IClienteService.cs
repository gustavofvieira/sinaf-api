using SinafApi.Domain.Models;
using System.Collections.Generic;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface IClienteService : IBaseService<Cliente>
    {
       
        void Cadastrar(Cliente cliente);
        List<Cliente> buscarPorNome(string nome);
    }
}
