using ClothingStore.Application.Common.Exceptions;
using ClothingStore.Application.Dtos;
using ClothingStore.Application.Services.Interfces;
using ClothingStore.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ClothingStore.Application.Mediator.Account.Commands.Register;

internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, TokenDto>
{
    private readonly ITokenService _tokenService;
    private readonly UserManager<User> _userManager;

    public RegisterCommandHandler(UserManager<User> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<TokenDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
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
        var refreshToken = _tokenService.GenerateRefreshToken();
        user.RefreshToken = refreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(1);
        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded) throw new Exception();

        var token = new TokenDto
        {
            AccessToken = await _tokenService.GenerateAccessTokenAsync(user),
            RefreshToken = refreshToken
        };
        return token;
    }
}