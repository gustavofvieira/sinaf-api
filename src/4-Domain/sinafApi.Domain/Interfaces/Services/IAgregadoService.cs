using SinafApi.Domain.Models;
using System.Collections.Generic;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface IAgregadoService : IBaseService<Agregado>
    {
       
        void Cadastrar(Agregado agregado);
        List<Agregado> buscarPorNome(string nome);
    }
}
