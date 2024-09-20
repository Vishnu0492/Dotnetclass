using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPFdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}