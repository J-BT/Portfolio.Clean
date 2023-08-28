using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.CreateTechnology;

public class CreateTechnologyCommandValidator : AbstractValidator<CreateTechnologyCommand>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public CreateTechnologyCommandValidator()
    {
        RuleFor(p => p.TechnoName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} must be fewer than 100 characters");
    }
    #endregion

    #region Methods

    #endregion
}
