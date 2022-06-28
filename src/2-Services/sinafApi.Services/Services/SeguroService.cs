
using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinafApi.Services.Services
{
    public class SeguroService : BaseService<Seguro>, ISeguroService
    {
        private readonly ISeguroRepository _seguroRepository;


        public SeguroService(ISeguroRepository seguroRepository)
           : base(seguroRepository)
        {
            _seguroRepository = seguroRepository;
        }

        public void Cadastrar(Seguro Seguro)
        {
            _seguroRepository.Add(Seguro);
        }

        public List<Seguro> buscarPorNome (string nome)
        {
            return _seguroRepository.GetByToList(s => s.Nome.Contains(nome)).ToList();
        }
    }

}
