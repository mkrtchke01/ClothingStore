using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using ClothingStore.Domain;
using Microsoft.IdentityModel.Tokens;

namespace ClothingStore.Application.Common.Jwt
{
    internal class TokenService : ITokenService
    {
        public async Task<string> GenerateAccessTokenAsync(User user)
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

        public string GenerateRefreshToken()
        {
            var tokenByte = RandomNumberGenerator.GetBytes( 64 );
            var refreshToken = Convert.ToBase64String( tokenByte );
            return refreshToken;
        }
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = JwtOptions.GetSymmetricSecurityKey(),
                ValidateLifetime = false
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("This is invalid token");
            }
            return principal;
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
