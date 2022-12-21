using ClothingStore.Application.Requests;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Commands.CreateProduct;

public class CreateProductCommand : IRequest<int>
{
    public CreateProductRequest CreateProductRequest { get; set; }
}