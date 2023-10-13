using Portfolio.Clean.Application.Contracts.Persistence.Common;
using Portfolio.Clean.Domain;

namespace Portfolio.Clean.Application.Contracts.Persistence;

/// <summary>
/// IProjectRepository describes the methods specific to 'Project' entity 
/// </summary>
public interface IProjectRepository : IGenericRepository<Project>
{
    Task<bool> IsProjectUnique(string projectName);
    Task<Project> GetProjectWithDetails(string projectName);
    Task<List<Project>> GetProjectsViaTechnology(string technology);
    Task<List<Project>> GetAllProjects();
}
