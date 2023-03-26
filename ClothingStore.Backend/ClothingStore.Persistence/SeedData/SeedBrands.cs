
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.SeedData
{
    internal class SeedBrands : IEntityTypeConfiguration<Brand>
    {
        private List<Brand> Brands = new()
        {
            new Brand() { BrandId = 1, BrandName = "Adidas", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now}, new Brand() { BrandId = 2, BrandName = "Puma" , CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now},
            new Brand() {BrandId = 3,  BrandName = "Nike", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Brand() { BrandId = 4, BrandName = "Diadora", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Brand() { BrandId = 5, BrandName = "The North Face", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Brand() { BrandId = 6, BrandName = "Fred Perry", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Brand() { BrandId = 7, BrandName = "Asics", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Brand() { BrandId = 8, BrandName = "Vans", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Brand() { BrandId = 9, BrandName = "Reebook", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Brand() { BrandId = 10, BrandName = "Converse", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Brand() { BrandId = 11, BrandName = "ТВОЕ", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Brand() { BrandId = 12, BrandName = "Mark Formelle", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
        };
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(Brands);
        }
    }
}
