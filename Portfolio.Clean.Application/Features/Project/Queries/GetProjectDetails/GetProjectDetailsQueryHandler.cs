using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Queries.GetProjectDetails;

public class GetProjectDetailsQueryHandler : IRequestHandler<GetProjectDetailsQuery, ProjectDetailsDto>
{
	#region Attributes & Accessors
	private readonly IMapper _mapper;
	private readonly IProjectRepository _projectRepository;
	#endregion

	#region Constructors
	public GetProjectDetailsQueryHandler(IMapper mapper, IProjectRepository projectRepository)
    {
		_mapper = mapper;
		_projectRepository = projectRepository;
	}

	#endregion

	#region Methods
	public async Task<ProjectDetailsDto> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
	{
		// Query the database
		var project = await _projectRepository.GetProjectWithDetails(request.ProjectName);

		// Verify that record exist
		if (project == null)
			throw new NotFoundException(nameof(Project), request.ProjectName);

		// Convert data to DTO object
		var data = _mapper.Map<ProjectDetailsDto>(project);

		// return DTO object
		return data;
	}
	#endregion
}
