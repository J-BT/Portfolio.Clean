using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Commands.CreateProject;

public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, string>
{

	#region Attributes & Accessors

	private readonly IMapper _mapper;
	private readonly IProjectRepository _projectRepository;

	#endregion

	#region Constructors
	public CreateProjectCommandHandler(IMapper mapper, IProjectRepository projectRepository)
    {
		_mapper = mapper;
		_projectRepository = projectRepository;
	}
    #endregion

    #region Methods
    public async Task<string> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
	{
		// Validate incoming data
		var validator = new CreateProjectCommandValidator(_projectRepository);
		var validationResult = await validator.ValidateAsync(request);

		if (validationResult.Errors.Any())
			throw new BadRequestException("Invalid Project", validationResult);

		// Convert to entity object
		var projectToCreate = _mapper.Map<Domain.Project>(request);

		// Add to database
		await _projectRepository.CreateAsync(projectToCreate);

		// Return record ProjectName
		return projectToCreate.ProjectName;
	}
	#endregion

}
