using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = new[] { "Value1", "Value2", "Value3" };
            return Ok(values);
        }
    }
}