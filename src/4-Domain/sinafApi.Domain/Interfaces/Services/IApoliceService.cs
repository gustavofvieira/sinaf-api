using SinafApi.Domain.Models;
using System.Collections.Generic;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface IApoliceService : IBaseService<Apolice>
    {
       
        void Cadastrar(Apolice apolice);
    }
}
