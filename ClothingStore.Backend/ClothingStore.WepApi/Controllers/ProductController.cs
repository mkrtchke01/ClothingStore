using ClothingStore.Application.Mediator.Product.Commands.CreateProduct;
using ClothingStore.Application.Mediator.Product.Commands.DeleteProduct;
using ClothingStore.Application.Mediator.Product.Queries.GetAllProducts;
using ClothingStore.Application.Mediator.Product.Queries.GetProductDetails;
using ClothingStore.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WepApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ClothingStoreControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("createProduct")]
    public async Task<IActionResult> CreateProduct(CreateProductRequest createProductRequest)
    {
        var validator = new CreateProductRequestValidator();
        var validateResult = await validator.ValidateAsync(createProductRequest);
        if (!validateResult.IsValid) return BadRequest(validateResult.Errors);
        var productId = await _mediator.Send(new CreateProductCommand
        {
            CreateProductRequest = createProductRequest
        });
        return Ok(productId);
    }

    [HttpGet("getAllProducts")]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _mediator.Send(new GetAllProductsQuery());
        if (products.Count == 0) return NoContent();
        return Ok(products);
    }

    [HttpGet("getProductDetails/{productId}")]
    public async Task<IActionResult> GetProductDetails([FromRoute] int productId)
    {
        var product = await _mediator.Send(new GetProductDetailsQuery
        {
            ProductId = productId
        });
        return Ok(product);
    }

    [HttpDelete("deleteProduct/{productId}")]
    public async Task<IActionResult> DeleteProduct([FromRoute] int productId)
    {
        await _mediator.Send(new DeleteProductCommand
        {
            ProductId = productId
        });
        return Ok();
    }
}