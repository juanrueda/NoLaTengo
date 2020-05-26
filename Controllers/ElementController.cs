using Microsoft.AspNetCore.Mvc;

namespace NoLaTengo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ElementController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAllElements()
        {
            return Ok();
        }

    }

}