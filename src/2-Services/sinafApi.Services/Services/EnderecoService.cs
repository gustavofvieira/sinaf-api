
using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinafApi.Services.Services
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;


        public EnderecoService(IEnderecoRepository enderecoRepository)
           : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public void Cadastrar(Endereco endereco)
        {
            _enderecoRepository.Add(endereco);
        }
    }

}
