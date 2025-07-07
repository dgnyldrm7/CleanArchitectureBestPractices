using CleanArchitecture.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetValues()
        {
            var values = new[] { "Value1", "Value2", "Value3" };
            return Ok(values);
        }

        [HttpGet]
        [Route("MediatorTest")]
        public async Task<IActionResult> MediatorTest()
        {
            // This is a placeholder for a MediatR request.
            // You would typically send a request to MediatR here.
            var response = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }

    }
}
