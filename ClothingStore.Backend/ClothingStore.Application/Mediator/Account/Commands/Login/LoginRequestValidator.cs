using ClothingStore.Application.Requests;
using FluentValidation;

namespace ClothingStore.Application.Mediator.Account.Commands.Login
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(loginRequestValidator =>
                loginRequestValidator.UserName)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(loginRequestValidator =>
                loginRequestValidator.Password)
                .NotEmpty()
                .MinimumLength(7);
        }
    }
}
