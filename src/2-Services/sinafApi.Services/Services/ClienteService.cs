
using SinafApi.Domain.Interfaces.Repositories;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinafApi.Services.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;


        public ClienteService(IClienteRepository clienteRepository)
           : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Cadastrar(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }

        public List<Cliente> buscarPorNome (string nome)
        {
            return _clienteRepository.GetByToList(c => c.Nome.Contains(nome)).ToList();
        }
    }

}
