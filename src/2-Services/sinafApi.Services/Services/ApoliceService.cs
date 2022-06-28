
using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinafApi.Services.Services
{
    public class ApoliceService : BaseService<Apolice>, IApoliceService
    {
        private readonly IApoliceRepository _apoliceRepository;


        public ApoliceService(IApoliceRepository apoliceRepository)
           : base(apoliceRepository)
        {
            _apoliceRepository = apoliceRepository;
        }

        public void Cadastrar(Apolice Apolice)
        {
            _apoliceRepository.Add(Apolice);
        }
    }

}
