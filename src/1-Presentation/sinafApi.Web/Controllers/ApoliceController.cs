using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SinafApi.Domain.Interfaces.Services;
using SinafApi.Domain.Models;

namespace sinafApi.Web.Controllers
{

    [ApiController]
    [Route("apolice")]
    public class ApoliceController : ControllerBase
    {
        private readonly IApoliceService _apoliceService;
        private readonly ILogger<ApoliceController> _logger;
        public ApoliceController(IApoliceService apoliceService, ILogger<ApoliceController> logger)
        {
            _apoliceService = apoliceService;
            _logger = logger;

        }

        [HttpPost]
        [Route("cadastrar")]
        public ActionResult cadastrarApolice(Apolice apolice)
        {
            _apoliceService.Cadastrar(apolice);
            _logger.LogInformation("Apolice cadastrado com sucesso.");
            return Ok("Apolice cadastrada com sucesso.");
        }
    }
}
