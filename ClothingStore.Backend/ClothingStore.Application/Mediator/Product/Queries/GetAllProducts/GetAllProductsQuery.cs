using ClothingStore.Application.Responses;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<IList<GetProductResponse>>
{
}