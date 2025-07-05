using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = new[] { "Value1", "Value2", "Value3" };
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            if (id < 1 || id > 3)
            {
                return NotFound();
            }

            var value = $"Value{id}";
            return Ok(value);
        }
    }
}
