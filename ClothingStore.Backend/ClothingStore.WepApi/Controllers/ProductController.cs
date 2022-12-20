using Azure.Core;
using ClothingStore.Application.Mediator.Product.Commands.CreateProduct;
using ClothingStore.Application.Mediator.Product.Commands.CreateProduct.Request;
using ClothingStore.Application.Mediator.Product.Commands.CreateProduct.Validation;
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
            var validator = new CreateProductRequestValidator();
            var result = await validator.ValidateAsync(createProductRequest);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }
            var productId = await _mediator.Send(new CreateProductCommand
            {
                CreateProductRequest = createProductRequest
            });
            return Ok(productId);
        }
    }
}
