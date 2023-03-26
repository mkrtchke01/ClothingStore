using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Persistence.Interfaces;

public interface IClothingStoreDbContext
{
    DbSet<Product> Products { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<Location> Locations { get; set; }
    DbSet<Season> Seasons { get; set; }
    DbSet<Gender> Genders { get; set; }
    DbSet<Color> Colors { get; set; }
    DbSet<Brand> Brands { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}