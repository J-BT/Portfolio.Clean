using AutoMapper;
using Portfolio.Clean.Application.Features.Project.Commands.CreateProject;
using Portfolio.Clean.Application.Features.Project.Commands.UpdateProject;
using Portfolio.Clean.Application.Features.Project.Queries.GetAllProjects;
using Portfolio.Clean.Application.Features.Project.Queries.GetProjectDetails;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.MappingProfiles;
/// <summary>
/// ProjectProfile which inherits of 'AutoMapper.Profile' class, creates a mapping for all Project entities.
/// According to the CQRS (Command and Query Responsibility Segregation) pattern, 
/// Domain entites are converted into DTO (Data Transfert Object) inside 'Queries' features and Command entites are
/// converted into Domain entites inside 'Commands' features.
/// </summary>
public class ProjectProfile : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public ProjectProfile()
    {
        CreateMap<ProjectDto, Project>().ReverseMap();    
        CreateMap<Project, ProjectDetailsDto>().ReverseMap();
        CreateMap<CreateProjectCommand, Project>();
        CreateMap<UpdateProjectCommand, Project>();
    }
    #endregion

    #region Methods

    #endregion
}
