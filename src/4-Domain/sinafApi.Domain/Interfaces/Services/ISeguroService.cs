using SinafApi.Domain.Models;
using System.Collections.Generic;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface ISeguroService : IBaseService<Seguro>
    {
       
        void Cadastrar(Seguro seguro);
        List<Seguro> buscarPorNome(string nome);
    }
}
