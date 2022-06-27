using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;

namespace SinafApi.Web.Controllers
{
[ApiController]
[Route("cliente")]
public class ClienteController : ControllerBase
{
        private readonly IClienteService _clienteService;
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(IClienteService clienteService, ILogger<ClienteController> logger)
        {
            _clienteService = clienteService;
            _logger = logger;

        }

        [HttpPost]
        [Route("cadastrar")]
        public ActionResult cadastrarCliente(Cliente cliente)
        {
            _clienteService.Cadastrar(cliente);
            return Ok("Cliente cadastrado com sucesso.");
        }

        [HttpGet]
        public ActionResult cadastraCliente()
        {
            return Ok("Cliente cadastrado com sucesso.");
        }

    }
}
