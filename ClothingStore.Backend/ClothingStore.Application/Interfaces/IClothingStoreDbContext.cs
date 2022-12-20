using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Application.Interfaces;

public interface IClothingStoreDbContext
{
    DbSet<Product> Products { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}