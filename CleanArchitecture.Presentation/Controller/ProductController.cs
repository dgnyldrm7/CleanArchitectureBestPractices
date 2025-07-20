namespace CleanArchitecture.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = new[] { ColorNames.FIRST_COLOR_NAME, "Value2", "Value3" };
            return Ok(values);
        }
    }
}