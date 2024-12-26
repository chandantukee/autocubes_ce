using FluentValidation;

namespace AutoCubes.Application.Commands.Countries.Create
{
    public class CreateCountryValidator : AbstractValidator<CreateCountryCommand>
    {
        public CreateCountryValidator()
        {
            RuleFor(x => x.CountryCode)
            .NotEmpty().WithMessage("Code is required.")
            .MaximumLength(6).WithMessage("Code cannot exceed 6 characters.");

            RuleFor(x => x.CountryName)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(x => x.CountryName)
            .NotEmpty().WithMessage("Alias is required.")
            .MaximumLength(45).WithMessage("Alias cannot exceed 45 characters.");
        }
    }
}
