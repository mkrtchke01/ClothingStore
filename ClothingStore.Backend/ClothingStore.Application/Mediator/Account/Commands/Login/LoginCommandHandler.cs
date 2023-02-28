﻿using ClothingStore.Application.Common.Exceptions;
using ClothingStore.Application.Common.Jwt;
using ClothingStore.Application.Responses;
using ClothingStore.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ClothingStore.Application.Mediator.Account.Commands.Login
{
    internal class LoginCommandHandler : IRequestHandler<LoginCommand, TokenResponse>
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<TokenResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (user == null || !result.Succeeded) throw new NotFoundException(nameof(User), user);

            var token = new TokenResponse();
            token.AccessToken = await _tokenService.GetAccessTokenAsync(user);

            return token;
        }
    }
}