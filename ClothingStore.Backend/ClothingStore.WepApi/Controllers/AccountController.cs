using ClothingStore.Application.Dtos;
using ClothingStore.Application.Mediator.Account.Commands.Login;
using ClothingStore.Application.Mediator.Account.Commands.Register;
using ClothingStore.Application.Mediator.Product.Commands.CreateProduct;
using ClothingStore.Application.Requests;
using ClothingStore.Application.Services.Interfces;
using ClothingStore.Domain;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WepApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ClothingStoreControllerBase
{
    private readonly IMediator _mediator;
    private readonly ITokenService _tokenService;
    private readonly UserManager<User> _userManager;

    public AccountController(IMediator mediator, ITokenService tokenService, UserManager<User> userManager)
    {
        _mediator = mediator;
        _tokenService = tokenService;
        _userManager = userManager;
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("signIn")]
    public async Task<IActionResult> SignIn(LoginRequest loginRequest)
    {
        var validator = new LoginRequestValidator();
        var validateResult = await validator.ValidateAsync(loginRequest);
        if (!validateResult.IsValid) return BadRequest(validateResult.Errors);
        var result = await _mediator.Send(new LoginCommand
        {
            UserName = loginRequest.UserName,
            Password = loginRequest.Password
        });
        return Ok(result);
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("signUp")]
    public async Task<IActionResult> SignUp(RegisterRequest registerRequest)
    {
        var validator = new RegisterRequestValidator();
        var validateResult = await validator.ValidateAsync(registerRequest);
        if (!validateResult.IsValid) return BadRequest(validateResult.Errors);
        var result = await _mediator.Send(new RegisterCommand
        {
            UserName = registerRequest.UserName,
            Password = registerRequest.Password,
            PasswordConfirm = registerRequest.PasswordConfirm,
            Country = registerRequest.Country,
            City = registerRequest.City,
            Index = registerRequest.Index
        });

        return Ok(result);
    }

    [HttpPost("refresh")]
    [AllowAnonymous]
    public async Task<IActionResult> Refresh(TokenDto tokenDto)
    {
        if (string.IsNullOrEmpty(tokenDto.AccessToken) || string.IsNullOrEmpty(tokenDto.RefreshToken))
            return BadRequest("Failed request from client");
        var accessToken = tokenDto.AccessToken;
        var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
        var userName = principal.Identity.Name;
        var user = await _userManager.FindByNameAsync(userName);
        var newRefreshToken = _tokenService.GenerateRefreshToken();
        user.RefreshToken = newRefreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(1);
        await _userManager.UpdateAsync(user);
        var token = new TokenDto
        {
            AccessToken = await _tokenService.GenerateAccessTokenAsync(user),
            RefreshToken = newRefreshToken
        };
        return Ok(token);
    }
}