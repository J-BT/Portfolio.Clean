using Microsoft.EntityFrameworkCore;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Domain;
using Portfolio.Clean.Persistence.DatabaseContext;

namespace Portfolio.Clean.Persistence.Repositories;

public class TechnologyRepository : GenericRepository<Technology>, ITechnologyRepository
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public TechnologyRepository(PortfolioDatabaseContext context)
        : base(context)
    {
    }

    #endregion

    #region Methods
    public async Task<bool> IsTechnologyUnique(string name)
    {
        return await _context.Technologies.AnyAsync(q => q.TechnoName == name);
    }

    public async Task<Technology> GetTechnologyWithDetails(string technoName)
    {
        var technology = await _context.Technologies
            .FirstOrDefaultAsync(q => q.TechnoName == technoName);

        //return technology == null ? new Technology() : technology;
        return technology;
    }
    #endregion

}
