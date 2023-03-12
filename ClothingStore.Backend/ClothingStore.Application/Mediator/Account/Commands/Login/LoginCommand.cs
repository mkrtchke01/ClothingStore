using ClothingStore.Application.Dtos;
using MediatR;

namespace ClothingStore.Application.Mediator.Account.Commands.Login;

public class LoginCommand : IRequest<TokenDto>
{
    public string UserName { get; set; }
    public string Password { get; set; }
}