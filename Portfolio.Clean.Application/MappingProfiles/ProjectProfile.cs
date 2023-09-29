using AutoMapper;
using Portfolio.Clean.Application.Features.Project.Queries.GetAllProjects;
using Portfolio.Clean.Application.Features.Project.Queries.GetProjectDetails;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.MappingProfiles;

public class ProjectProfile : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public ProjectProfile()
    {
        CreateMap<ProjectDto, Project>();    
        CreateMap<Project, ProjectDetailsDto>();    
    }
    #endregion

    #region Methods

    #endregion
}
