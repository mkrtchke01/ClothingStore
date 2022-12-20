using ClothingStore.Application.Mediator.Product.Commands.CreateProduct;
using ClothingStore.Application.Mediator.Product.Commands.CreateProduct.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest createProductRequest)
        {
            var product = await _mediator.Send(new CreateProductCommand
            {
                CreateProductRequest = createProductRequest
            });
            return Ok();
        }
    }
}
