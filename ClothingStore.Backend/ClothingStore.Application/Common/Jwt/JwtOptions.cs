using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ClothingStore.Application.Common.Jwt;

internal class JwtOptions
{
    public const string Issuer = "ClothingStoreBackend";
    public const string Audience = "ClothingStoreFrontend";
    private const string Key = "clothingstore!!!2023";
    public static DateTime Lifetime = DateTime.Now.AddDays(1);

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
    }
}