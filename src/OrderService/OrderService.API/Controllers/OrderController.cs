using Microsoft.AspNetCore.Mvc;

namespace OrderService.API.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult GetTest()
        {
            return Ok("OrderService'den merhaba!");
        }
    }
}
