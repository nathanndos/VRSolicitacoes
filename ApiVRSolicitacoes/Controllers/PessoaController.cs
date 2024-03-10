using BLL;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {

        [HttpGet]
        public IActionResult getAll()
        {
            var result = PessoaBLL.list();
            return Ok(result);
        }

        [HttpGet("{ide}")]
        public IActionResult get(Guid ide)
        {
            var result = PessoaBLL.get(ide);
            return Ok(result);
        }
    }
}
