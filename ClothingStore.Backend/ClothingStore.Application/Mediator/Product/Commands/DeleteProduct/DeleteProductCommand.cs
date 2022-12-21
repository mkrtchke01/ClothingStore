using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int ProductId { get; set; }
    }
}
