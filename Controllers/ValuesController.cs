using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult Greeting()
        {
            string message = "Hi world";
            return Ok(message);
        }


    }
}

