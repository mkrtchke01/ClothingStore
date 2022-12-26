using ClothingStore.Domain;
using ClothingStore.Persistence.Interfaces;
using MediatR;

namespace ClothingStore.Application.Mediator.Product.Commands.CreateProduct;

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IClothingStoreDbContext _context;

    public CreateProductCommandHandler(IClothingStoreDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Product
        {
            ProductName = request.CreateProductRequest.ProductName,
            Description = request.CreateProductRequest.Description,
            Price = request.CreateProductRequest.Price,
            Image = request.CreateProductRequest.Image,
            User = new User
            {
                UserName = "Egor",
                PhoneNumber = "+375336115820",
                Location = new Location
                {
                    Country = "Belarus",
                    City = "Vitebsk",
                    Index = "210021"
                }
            },
            Gender = new Gender
            {
                GenderName = request.CreateProductRequest.GenderName
            },
            Brand = new Brand
            {
                BrandName = request.CreateProductRequest.BrandName
            },
            CreatedDate = DateTime.Now
        };
        foreach (var seasonName in request.CreateProductRequest.SeasonNames)
            product.Seasons = new List<Season>
            {
                new()
                {
                    SeasonName = seasonName
                }
            };

        foreach (var colorName in request.CreateProductRequest.ColorNames)
            product.Colors = new List<Color>
            {
                new()
                {
                    ColorName = colorName
                }
            };

        await _context.Products.AddAsync(product, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return product.ProductId;
    }
}