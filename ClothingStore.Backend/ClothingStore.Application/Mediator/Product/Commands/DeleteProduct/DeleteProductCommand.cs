using MediatR;

namespace ClothingStore.Application.Mediator.Product.Commands.DeleteProduct;

public class DeleteProductCommand : IRequest
{
    public int ProductId { get; set; }
}