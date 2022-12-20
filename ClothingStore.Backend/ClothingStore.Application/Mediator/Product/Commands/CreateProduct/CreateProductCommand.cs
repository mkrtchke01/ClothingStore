using ClothingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Application.Mediator.Product.Commands.CreateProduct.Request;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public CreateProductRequest CreateProductRequest { get; set; }
    }
}
