using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ClothingStore.Application.Common.Exceptions;
using ClothingStore.Application.Interfaces;
using ClothingStore.Application.Mediator.Product.Queries.GetProductDetails;
using ClothingStore.Application.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Application.Mediator.Product.Queries.GetProductDetails
{
    internal class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery, GetProductDetailsResponse>
    {
        private readonly IClothingStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetProductDetailsQueryHandler(IClothingStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetProductDetailsResponse> Handle(GetProductDetailsQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .AsNoTracking()
                .Include(x=>x.Brand)
                .Include(x=>x.Gender)
                .Include(x=>x.Colors)
                .Include(x=>x.Seasons)
                .Include(x=>x.User)
                .FirstOrDefaultAsync(i => i.ProductId == request.ProductId, cancellationToken);
            if (product == null)
            {
                throw new NotFoundException(nameof(Domain.Product), request.ProductId);
            }
            return _mapper.Map<GetProductDetailsResponse>(product);
        }
    }
}
