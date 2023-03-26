using ClothingStore.Domain;
using ClothingStore.Persistence.EntityTypeConfiguration;
using ClothingStore.Persistence.Interfaces;
using ClothingStore.Persistence.SeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Persistence;

public class ClothingStoreDbContext : IdentityDbContext<User>, IClothingStoreDbContext
{
    public ClothingStoreDbContext(DbContextOptions<ClothingStoreDbContext> options)
        : base(options)
    {
    }

    public override DbSet<User> Users { get; set; }
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

        modelBuilder.ApplyConfiguration(new SeedBrands());
        modelBuilder.ApplyConfiguration(new SeedColors());
        modelBuilder.ApplyConfiguration(new SeedGenders());
        modelBuilder.ApplyConfiguration(new SeedSeasons());
        modelBuilder.ApplyConfiguration(new SeedLocations());
        modelBuilder.ApplyConfiguration(new SeedUsers());
        modelBuilder.ApplyConfiguration(new SeedProducts());

        base.OnModelCreating(modelBuilder);
    }
}