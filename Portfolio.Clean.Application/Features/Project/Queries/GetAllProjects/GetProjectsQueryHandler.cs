using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Logging;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Project.Queries.GetAllProjects;

public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, List<ProjectDto>>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;
    private readonly IAppLogger<GetProjectsQueryHandler> _logger;

    #endregion

    #region Constructors
    public GetProjectsQueryHandler(IMapper mapper,
        IProjectRepository projectRepository,
        IAppLogger<GetProjectsQueryHandler> logger)
    {
        _mapper = mapper;
        _projectRepository = projectRepository;
        _logger = logger;
    }

    #endregion

    #region Methods
    public async Task<List<ProjectDto>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var projects = await _projectRepository.GetAllProjects();

        // Convert data object to Dto objects
        var data = _mapper.Map<List<ProjectDto>>(projects);

        // return list of DTO objects
        _logger.LogInformation("Projects were retrieved succesfully");
        return data;
    }
    #endregion
}
