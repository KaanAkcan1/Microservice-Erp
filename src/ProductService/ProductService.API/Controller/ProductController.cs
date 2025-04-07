using Microsoft.AspNetCore.Mvc;

namespace ProductService.API.Controller
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult GetTest()
        {
            return Ok("ProductService'den merhaba!");
        }
    }
}
