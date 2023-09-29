using FluentValidation;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Commands.UpdateProject;

public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
{

	#region Attributes & Accessors

	private readonly IProjectRepository _projectRepository;

	#endregion

	#region Constructors
	public UpdateProjectCommandValidator(IProjectRepository projectRepository)
    {
		RuleFor(p => p.Id)
			.NotNull()
			.MustAsync(ProjectMustExists);

		RuleFor(p => p.ProjectName)
			.NotEmpty().WithMessage("{PropertyName} is required")
			.NotNull()
			.MaximumLength(255).WithMessage("{PropertyName} must be fewer than 255 characters");
			//.MustAsync(ProjectMustExists);
			

		RuleFor(p => p.ProjectTechnologies)
			.NotEmpty().WithMessage("{PropertyName} is required")
			.NotNull();

		_projectRepository = projectRepository;
	}

	#endregion

	#region Methods

	private async Task<bool> ProjectMustExists(int id, CancellationToken token)
	{
		var project = await _projectRepository.GetAsyncById(id);
		return project != null;
	}

	#endregion
}
