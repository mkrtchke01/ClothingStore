
using ClothingStore.Application.Requests;
using FluentValidation;

namespace ClothingStore.Application.Mediator.Account.Commands.Register
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(registerRequestValidator =>
                registerRequestValidator.UserName)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(registerRequestValidator =>
                registerRequestValidator.Password)
                .NotEmpty()
                .MinimumLength(7);
            RuleFor(registerRequestValidator =>
                    registerRequestValidator.PasswordConfirm)
                .Equal(registerRequestValidator => registerRequestValidator.Password)
                .NotEmpty()
                .MinimumLength(7);
        }
    }
}
