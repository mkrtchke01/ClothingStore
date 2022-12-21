using ClothingStore.Application.Responses;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Queries.GetProductDetails;

public class GetProductDetailsQuery : IRequest<GetProductDetailsResponse>
{
    public int ProductId { get; set; }
}