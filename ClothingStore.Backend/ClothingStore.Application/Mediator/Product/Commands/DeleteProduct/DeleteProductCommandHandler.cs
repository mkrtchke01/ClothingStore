using ClothingStore.Application.Common.Exceptions;
using ClothingStore.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Application.Mediator.Product.Commands.DeleteProduct;

internal class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly IClothingStoreDbContext _context;

    public DeleteProductCommandHandler(IClothingStoreDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product =
            await _context.Products.FirstOrDefaultAsync(i => i.ProductId == request.ProductId, cancellationToken);
        if (product == null) throw new NotFoundException(nameof(Domain.Product), request.ProductId);
        _context.Products.Remove(product);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}