using ClothingStore.Application.Interfaces;
using ClothingStore.Domain;
using ClothingStore.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Persistence;

public class ClothingStoreDbContext : DbContext, IClothingStoreDbContext
{
    public ClothingStoreDbContext(DbContextOptions<ClothingStoreDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Season> Seasons { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new SeasonConfiguration());
        modelBuilder.ApplyConfiguration(new GenderConfiguration());
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        modelBuilder.ApplyConfiguration(new BrandConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}