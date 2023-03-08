
using ClothingStore.Domain;
using System.Security.Claims;

namespace ClothingStore.Application.Common.Jwt
{
    public interface ITokenService
    {
        Task<string> GenerateAccessTokenAsync(User user);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
