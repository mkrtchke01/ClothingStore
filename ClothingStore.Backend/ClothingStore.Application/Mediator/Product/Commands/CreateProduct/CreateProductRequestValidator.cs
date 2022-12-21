using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Application.Requests;
using FluentValidation;

namespace ClothingStore.Application.Mediator.Product.Commands.CreateProduct
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(createProductRequest =>
                createProductRequest.ProductName).NotEmpty().MaximumLength(30);
            RuleFor(createProductRequest =>
                createProductRequest.Description).MaximumLength(250);
            RuleFor(createProductRequest =>
                createProductRequest.Price).PrecisionScale(9, 2, false);
            RuleFor(createProductRequest =>
                createProductRequest.Image).NotEmpty();
            RuleFor(createProductRequest =>
                createProductRequest.GenderName).NotEmpty().MaximumLength(20);
            RuleFor(createProductRequest =>
                createProductRequest.BrandName).NotEmpty().MaximumLength(35);

        }
    }
}
