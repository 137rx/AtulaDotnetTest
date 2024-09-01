using FluentValidation;
using AtulaDotnetTest.DTOs;

namespace AtulaDotnetTest.Validators
{
    public class ProductDTOValidator : AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(p => p.Sku).NotEmpty().WithMessage("SKU is required");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}