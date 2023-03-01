
using ClothingStore.Domain;

namespace ClothingStore.Application.Common.Jwt
{
    internal interface ITokenService
    {
        Task<string> GenerateAccessTokenAsync(User user);
        string GenerateRefreshToken();
    }
}
