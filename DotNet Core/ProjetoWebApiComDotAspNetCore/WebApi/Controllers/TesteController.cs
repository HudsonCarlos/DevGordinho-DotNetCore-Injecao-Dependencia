using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TesteControllers: Controller
    {
        [HttpGet]
        public IActionResult Teste()
        {
            return Ok("A Api esta funcionando");
        }
    }
}