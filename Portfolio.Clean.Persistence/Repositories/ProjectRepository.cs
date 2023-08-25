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
    #endregion

}
