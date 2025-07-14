using CleanArchitecture.Domain.Products;
using FluentValidation;

namespace CleanArchitecture.Application.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .MaximumLength(100).WithMessage("Product name cannot exceed 100 characters.");

            RuleFor(product => product.Description)
                .MaximumLength(500).WithMessage("Product description cannot exceed 500 characters.");
        }
    }
}