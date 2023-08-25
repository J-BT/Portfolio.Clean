using Microsoft.EntityFrameworkCore;
using Portfolio.Clean.Application.Contracts.Persistence.Common;
using Portfolio.Clean.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> 
    where T : class
{

    #region Attributes & Accessors

    protected readonly PortfolioDatabaseContext _context;

    #endregion

    #region Constructors
    public GenericRepository(PortfolioDatabaseContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();

    }

    public async Task<IReadOnlyList<T>> GetAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetAsyncById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
    #endregion

    #region Methods

    #endregion
}
