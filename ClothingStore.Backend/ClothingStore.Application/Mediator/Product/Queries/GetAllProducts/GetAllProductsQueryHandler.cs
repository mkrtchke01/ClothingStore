using AutoMapper;
using ClothingStore.Application.Interfaces;
using ClothingStore.Application.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Application.Mediator.Product.Queries.GetAllProducts;

internal class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IList<GetProductResponse>>
{
    private readonly IClothingStoreDbContext _context;
    private readonly IMapper _mapper;

    public GetAllProductsQueryHandler(IClothingStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IList<GetProductResponse>> Handle(GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        var products = await _context.Products
            .AsNoTracking()
            .Include(user => user.User)
            .Include(brand => brand.Brand)
            .ToListAsync(cancellationToken);
        return _mapper.Map<IList<GetProductResponse>>(products);
    }
}