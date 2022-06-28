using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;

namespace sinafApi.Web.Controllers
{

    [ApiController]
    [Route("seguro")]
    public class SeguroController : ControllerBase
    {

        private readonly ISeguroService _seguroService;
        private readonly ILogger<SeguroController> _logger;
        public SeguroController(ISeguroService seguroService, ILogger<SeguroController> logger)
        {
            _seguroService = seguroService;
            _logger = logger;

        }

        [HttpPost]
        [Route("cadastrar")]
        public ActionResult cadastrarSeguro(Seguro seguro)
        {
            _seguroService.Cadastrar(seguro);
            _logger.LogInformation("Seguro cadastrado com sucesso.");
            return Ok("Seguro cadastrado com sucesso.");
        }

        [HttpGet]
        [Route("buscar")]
        public ActionResult buscarPorNome(string nome)
        {
            _logger.LogInformation("Busca por nome do seguro.");
            return Ok(_seguroService.buscarPorNome(nome));
        }

    }
}
