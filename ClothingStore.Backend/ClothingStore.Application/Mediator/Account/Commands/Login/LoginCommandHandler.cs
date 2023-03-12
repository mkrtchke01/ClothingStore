using ClothingStore.Application.Common.Exceptions;
using ClothingStore.Application.Dtos;
using ClothingStore.Application.Services.Interfces;
using ClothingStore.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ClothingStore.Application.Mediator.Account.Commands.Login;

internal class LoginCommandHandler : IRequestHandler<LoginCommand, TokenDto>
{
    private readonly SignInManager<User> _signInManager;
    private readonly ITokenService _tokenService;
    private readonly UserManager<User> _userManager;

    public LoginCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager,
        ITokenService tokenService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }

    public async Task<TokenDto> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);
        var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
        if (user == null || !result.Succeeded) throw new NotFoundException(nameof(User), user);

        var refreshToken = _tokenService.GenerateRefreshToken();
        user.RefreshToken = refreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(1);
        await _userManager.UpdateAsync(user);
        var token = new TokenDto
        {
            AccessToken = await _tokenService.GenerateAccessTokenAsync(user),
            RefreshToken = refreshToken
        };
        return token;
    }
}