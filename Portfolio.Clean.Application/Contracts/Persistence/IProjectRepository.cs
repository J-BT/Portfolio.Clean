using Portfolio.Clean.Application.Contracts.Persistence.Common;
using Portfolio.Clean.Domain;

namespace Portfolio.Clean.Application.Contracts.Persistence;

public interface IProjectRepository : IGenericRepository<Project>
{
    Task<bool> IsProjectUnique(string projectName);
    Task<Project> GetProjectWithDetails(string projectName);
    Task<List<Project>> GetProjectsWithDetails(string technology);
    Task<List<Project>> GetAllProjects();
}
