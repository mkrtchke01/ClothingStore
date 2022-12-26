
using ClothingStore.Domain;

namespace ClothingStore.Application.Common.Jwt
{
    internal interface ITokenService
    {
        Task<string> GetAccessTokenAsync(User user);
    }
}
