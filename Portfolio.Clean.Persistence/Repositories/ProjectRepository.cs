using Microsoft.EntityFrameworkCore;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Domain;
using Portfolio.Clean.Persistence.DatabaseContext;

namespace Portfolio.Clean.Persistence.Repositories;

public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public ProjectRepository(PortfolioDatabaseContext context)
        : base(context)
    {
    }

    #endregion

    #region Methods
    public async Task<bool> IsProjectUnique(string name)
    {
        return await _context.Projects.AnyAsync(q => q.ProjectName == name);
    }

    public async Task<List<Project>> GetAllProjects()
    {
        var projects = await _context.Projects
            .ToListAsync();
        return projects;
    }

    public async Task<List<Project>> GetProjectsWithDetails(string technology)
    {
        var projects = await _context.Projects
            .Where(q => q.ProjectTechnologies.Contains(technology))
            .ToListAsync();
        return projects;
    }

    public async Task<Project> GetProjectWithDetails(string projectName)
    {
        var project = await _context.Projects
            .FirstOrDefaultAsync(q => q.ProjectName == projectName);

        return project;
    }

    #endregion

}
