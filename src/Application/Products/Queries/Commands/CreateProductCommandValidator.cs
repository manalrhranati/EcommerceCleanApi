using FluentValidation;

namespace Application.Products.Commands;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(v => v.Name)
            .NotEmpty().WithMessage("Der Produktname darf nicht leer sein.")
            .MaximumLength(200);

        // Hier wird sichergestellt, dass der Preis größer als 0 sein muss
        RuleFor(v => v.Price)
            .GreaterThan(0).WithMessage("Der Preis muss größer als 0 sein.");
    }
}