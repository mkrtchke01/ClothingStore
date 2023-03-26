using System.Data.Common;
using ClothingStore.Domain;
using ClothingStore.Persistence;
using ClothingStore.Persistence.Interfaces;

namespace ClothingStore.SeedData
{
    internal class Seeding
    {
        private readonly IClothingStoreDbContext _context;

        private const string ConnectionString =
            "Server=localhost;Database=ClothingStore;Trusted_Connection=True;TrustServerCertificate=True;";

        private List<Brand> Brands = new()
        {
            new Brand() { BrandId = 1, BrandName = "Adidas" }, new Brand() { BrandId = 2, BrandName = "Puma" }, new Brand() {BrandId = 3,  BrandName = "Nike" }, 
            new Brand() { BrandId = 4, BrandName = "Diadora" }, new Brand() { BrandId = 5, BrandName = "The North Face" }, new Brand() { BrandId = 6, BrandName = "Fred Perry" }, 
            new Brand() { BrandId = 7, BrandName = "Asics" }, new Brand() { BrandId = 8, BrandName = "Vans" }, new Brand() { BrandId = 9, BrandName = "Reebook" }, 
            new Brand() { BrandId = 10, BrandName = "Converse" }, new Brand() { BrandId = 11, BrandName = "ТВОЕ" }, new Brand() { BrandId = 12, BrandName = "Mark Formelle" }
        };

        public Seeding()
        {
            
            
        }
        public async Task Execute()
        {
            await _context.Brands.AddRangeAsync(Brands);
            await _context.SaveChangesAsync(CancellationToken.None);
        }
    }
}
