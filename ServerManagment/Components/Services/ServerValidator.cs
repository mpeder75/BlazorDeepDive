using FluentValidation;
using ServerManagment.Models;

namespace ServerManagment.Components.Services;

public class ServerValidator : AbstractValidator<Server>
{
    public ServerValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(50).WithMessage("Name cannot be longer than 50 characters")
            .Matches(@"^[A-Za-z\s0-9]+$").WithMessage("Name must not contain special characters");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("City is required")
            .Matches(@"^[A-Za-z\s]+$").WithMessage("City must not contain numbers oo symbols");
    }

}