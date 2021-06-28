using Microsoft.AspNetCore.Mvc;
using Uniciv.Api.Repositories;

namespace Uniciv.Api.Controllers
{
    public class TesteCapitalController : Controller
    {
        public readonly ITesteCapitalRepository _repositoryTeste;
        public TesteCapitalController(ITesteCapitalRepository teste)
        {
            _repositoryTeste = teste;
        }

        [HttpGet("v1/testecapital")]
        public IActionResult ValidarInterface(){
            return Ok(_repositoryTeste.ValidarMetodoInterface());
        }
    }
}