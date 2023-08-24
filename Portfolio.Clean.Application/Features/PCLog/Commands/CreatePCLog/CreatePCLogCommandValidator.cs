using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Commands.CreatePCLog;

public class CreatePCLogCommandValidator : AbstractValidator<CreatePCLogCommand>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public CreatePCLogCommandValidator()
    {
        RuleFor(p => p.PCLogContent)
            .NotNull()
            .NotEmpty().WithMessage("{PropertyName} is required");
    }
    #endregion

    #region Methods

    #endregion
}
