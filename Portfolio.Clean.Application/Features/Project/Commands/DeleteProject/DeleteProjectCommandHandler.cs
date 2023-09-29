using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Commands.DeleteProject;

public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
{

	#region Attributes & Accessors

	private readonly IProjectRepository _projectRepository;

	#endregion

	#region Constructors
	public DeleteProjectCommandHandler(IProjectRepository projectRepository)
    {
		_projectRepository = projectRepository;
	}
    #endregion

    #region Methods

    public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
	{
		// Retrive domain entity object
		var projectToDelete = await _projectRepository.GetProjectWithDetails(request.ProjectName);

		// Verify that record exists
		if (projectToDelete == null)
			throw new NotFoundException(nameof(Project), request.ProjectName);

		// Remove record from database
		await _projectRepository.DeleteAsync(projectToDelete);

		// Return value unit
		return Unit.Value;
	}

	#endregion

}
