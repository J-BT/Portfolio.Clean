using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Logging;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Commands.UpdateProject;

public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
{

	#region Attributes & Accessors

	private readonly IMapper _mapper;
	private readonly IProjectRepository _projectRepository;
	private readonly IAppLogger<UpdateProjectCommandHandler> _logger;

	#endregion

	#region Constructors
	public UpdateProjectCommandHandler(IMapper mapper, IProjectRepository projectRepository, 
		IAppLogger<UpdateProjectCommandHandler> logger)
    {
		_mapper = mapper;
		_projectRepository = projectRepository;
		_logger = logger;
	}

	#endregion

	#region Methods
	public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
	{
		// Validate incoming data
		var validator = new UpdateProjectCommandValidator(_projectRepository);
		var validationResult = await validator.ValidateAsync(request);

		if (validationResult.Errors.Any())
		{
			_logger.LogWarning($"Validation errors in update request for {nameof(Project)} - {request.ProjectName}");
			throw new BadRequestException("Invalid Project", validationResult);
		}

		// Convert to domain entity
		var projectToUpdate = _mapper.Map<Domain.Project>(request);

		// Add to database
		await _projectRepository.UpdateAsync(projectToUpdate);

		// Return unit value
		return Unit.Value;
	}
	#endregion
}
