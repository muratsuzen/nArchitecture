using FluentValidation;

namespace Application.Features.Brands.Commands.CreateBrand;

public class CreateBrandCommandValidatior:AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidatior()
    {
        RuleFor(x=>x.Name).NotEmpty();
        RuleFor(x => x.Name).MinimumLength(2);
    }
}