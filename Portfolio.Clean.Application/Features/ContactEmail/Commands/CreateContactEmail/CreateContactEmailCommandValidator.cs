using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.CreateContactEmail;

public class CreateContactEmailCommandValidator : AbstractValidator<CreateContactEmailCommand>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public CreateContactEmailCommandValidator()
    {
        RuleFor(p => p.ContactEmailObject)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} must be fewer than 100 characters");

        RuleFor(p => p.ContactEmailContent)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

        RuleFor(p => p.ContactEmailSender)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

        //RuleFor(q => q)
        //    .MustAsync(TechnoNameUnique).WithMessage("TechnoName already exist");
    }
    #endregion

    #region Methods

    #endregion
}
