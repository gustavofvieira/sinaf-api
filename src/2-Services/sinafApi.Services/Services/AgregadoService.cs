
using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinafApi.Services.Services
{
    public class AgregadoService : BaseService<Agregado>, IAgregadoService
    {
        private readonly IAgregadoRepository _agregadoRepository;


        public AgregadoService(IAgregadoRepository agregadoRepository)
           : base(agregadoRepository)
        {
            _agregadoRepository = agregadoRepository;
        }

        public void Cadastrar(Agregado agregado)
        {
            _agregadoRepository.Add(agregado);
        }

        public List<Agregado> buscarPorNome (string nome)
        {
            return _agregadoRepository.GetByToList(c => c.Nome.Contains(nome)).ToList();
        }
    }

}
