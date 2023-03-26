
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.SeedData
{
    internal class SeedGenders : IEntityTypeConfiguration<Gender>
    {
        private List<Gender> Genders = new()
        {
            new Gender() { GenderId = 1, GenderName = "Male", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Gender() { GenderId = 2, GenderName = "Female", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
        };
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(Genders);
        }
    }
}
