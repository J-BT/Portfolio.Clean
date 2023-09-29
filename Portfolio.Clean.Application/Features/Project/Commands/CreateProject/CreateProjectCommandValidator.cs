using FluentValidation;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Commands.CreateProject;

public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
{

	#region Attributes & Accessors

	private readonly IProjectRepository _projectRepository;

	#endregion

	#region Constructors
	public CreateProjectCommandValidator(IProjectRepository projectRepository)
	{
		RuleFor(p => p.ProjectName)
			.NotEmpty().WithMessage("{PropertyName} is required")
			.NotNull()
			.MaximumLength(255).WithMessage("{PropertyName} must be fewer than 255 characters");

		RuleFor(p => p.ProjectTechnologies)
			.NotEmpty().WithMessage("{PropertyName} is required")
			.NotNull();

		RuleFor(q => q)
			.MustAsync(IsProjectUnique)
			.WithMessage("Project already exists");


		_projectRepository = projectRepository;
	}

	#endregion

	#region Methods
	private Task<bool> IsProjectUnique(CreateProjectCommand command, CancellationToken token)
	{
		return _projectRepository.IsProjectUnique(command.ProjectName);
	}
	#endregion
}
