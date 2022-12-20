using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ClothingStore.Application.Interfaces;
using ClothingStore.Domain;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Commands.CreateProduct
{
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IClothingStoreDbContext _context;

        public CreateProductCommandHandler(IClothingStoreDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Domain.Product()
            {
                ProductName = request.CreateProductRequest.ProductName,
                Description = request.CreateProductRequest.Description,
                Price = request.CreateProductRequest.Price,
                Image = request.CreateProductRequest.Image,
                User = new User()
                {
                    UserName = "Egor",
                    PhoneNumber = "+375336115820",
                    Location = new Location()
                    {
                        Country = "Belarus",
                        City = "Vitebsk",
                        Index = "210021"
                    }
                },
                Gender = new Gender()
                {
                    GenderName = request.CreateProductRequest.GenderName
                },
                Brand = new Brand()
                {
                    BrandName = request.CreateProductRequest.BrandName
                }
            };
            foreach (var seasonName in request.CreateProductRequest.SeasonNames)
            {
                product.Seasons = new List<Season>
                {
                    new Season()
                    {
                        SeasonName = seasonName
                    }
                };
            }

            foreach (var colorName in request.CreateProductRequest.ColorNames)
            {
                product.Colors = new List<Color>
                {
                    new Color()
                    {
                        ColorName = colorName
                    }
                };
            }

            _context.Products.Update(product);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
