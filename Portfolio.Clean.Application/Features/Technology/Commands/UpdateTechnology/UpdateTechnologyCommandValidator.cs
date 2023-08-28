using FluentValidation;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.UpdateTechnology;

public class UpdateTechnologyCommandValidator : AbstractValidator<UpdateTechnologyCommand>
{

    #region Attributes & Accessors
    private readonly ITechnologyRepository _technologyRepository;

    #endregion

    #region Constructors
    public UpdateTechnologyCommandValidator(ITechnologyRepository technologyRepository)
    {
        _technologyRepository = technologyRepository;

        RuleFor(p => p.Id)
            .NotNull()
            .MustAsync(TechnologyMustExit);

        RuleFor(p => p.TechnoName)
            .NotNull()
            .NotEmpty().WithMessage("{PropertyName} is required")
            .MustAsync(TechnologyIsUnique);
    }

    #endregion

    #region Methods
    private async Task<bool> TechnologyMustExit(int id, CancellationToken token)
    {
        return await _technologyRepository
            .GetAsyncById(id) != null;
    }

    private async Task<bool> TechnologyIsUnique(string technoName, CancellationToken token)
    {
        return await _technologyRepository
            .GetTechnologyWithDetails(technoName) == null;
    }
    #endregion
}
