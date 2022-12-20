using ClothingStore.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClothingStore.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ClothingStoreDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IClothingStoreDbContext, ClothingStoreDbContext>();

        return services;
    }
}