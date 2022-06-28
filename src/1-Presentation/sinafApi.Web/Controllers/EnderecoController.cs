using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;

namespace sinafApi.Web.Controllers
{

    [ApiController]
    [Route("endereco")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;
        private readonly ILogger<EnderecoController> _logger;
        public EnderecoController(IEnderecoService enderecoService, ILogger<EnderecoController> logger)
        {
            _enderecoService = enderecoService;
            _logger = logger;

        }

        [HttpPost]
        [Route("cadastrar")]
        public ActionResult cadastrarEndereco(Endereco endereco)
        {
            _enderecoService.Cadastrar(endereco);
            _logger.LogInformation("Endereco cadastrado com sucesso.");
            return Ok("Endereco cadastrado com sucesso.");
        }
    }
}
