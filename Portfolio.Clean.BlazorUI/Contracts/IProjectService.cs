using Portfolio.Clean.BlazorUI.Models.Projects;
using Portfolio.Clean.BlazorUI.Services.Base;

namespace Portfolio.Clean.BlazorUI.Contracts;

public interface IProjectService
{
	Task<List<ProjectVM>> GetProjects();
	Task<ProjectVM> GetProjectDetails(string projectName);
	Task<Response<Guid>> CreateProject(ProjectVM project);
	Task<Response<Guid>> UpdateProject(string projectName, ProjectVM project);
	Task<Response<Guid>> DeleteProject(string projectName);
}
