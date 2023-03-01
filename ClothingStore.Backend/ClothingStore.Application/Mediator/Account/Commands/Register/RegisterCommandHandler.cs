using ClothingStore.Application.Common.Exceptions;
using ClothingStore.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using ClothingStore.Application.Common.Jwt;
using ClothingStore.Application.Responses;

namespace ClothingStore.Application.Mediator.Account.Commands.Register
{
    internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, TokenResponse>
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public RegisterCommandHandler(UserManager<User> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        public async Task<TokenResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                UserName = request.UserName,
                Location = new Location
                {
                    Country = request.Country,
                    City = request.City,
                    Index = request.Index
                }
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded) throw new NotFoundException(nameof(User), user);

            var token = new TokenResponse();
            token.AccessToken = await _tokenService.GenerateAccessTokenAsync(user);
            token.RefreshToken = _tokenService.GenerateRefreshToken();
            return token;
        }
    }
}
