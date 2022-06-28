using SinafApi.Domain.Models;
using System.Collections.Generic;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface IEnderecoService : IBaseService<Endereco>
    {
       
        void Cadastrar(Endereco endereco);
    }
}
