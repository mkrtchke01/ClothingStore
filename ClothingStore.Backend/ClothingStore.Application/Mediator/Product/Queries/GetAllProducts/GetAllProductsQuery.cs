using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Application.Responses;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IList<GetProductResponse>>
    {
    }
}
