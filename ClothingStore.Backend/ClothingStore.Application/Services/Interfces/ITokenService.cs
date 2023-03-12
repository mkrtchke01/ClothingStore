using System.Security.Claims;
using ClothingStore.Domain;

namespace ClothingStore.Application.Services.Interfces;

public interface ITokenService
{
    Task<string> GenerateAccessTokenAsync(User user);
    string GenerateRefreshToken();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}