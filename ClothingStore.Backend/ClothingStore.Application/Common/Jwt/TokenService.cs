using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ClothingStore.Domain;
using Microsoft.IdentityModel.Tokens;

namespace ClothingStore.Application.Common.Jwt
{
    internal class TokenService : ITokenService
    {
        public async Task<string> GetAccessTokenAsync(User user)
        {
            var key = JwtOptions.GetSymmetricSecurityKey();
            var claims = await Task.Run(() => GetClaims(user));
            var token = new JwtSecurityTokenHandler().WriteToken
            (
                new JwtSecurityToken
                (
                    JwtOptions.Issuer,
                    JwtOptions.Audience,
                    claims,
                    expires: JwtOptions.Lifetime,
                    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                )
            );
            return token;
        }

        private List<Claim> GetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, user.Id)
            };
            return claims;
        }
    }
}
