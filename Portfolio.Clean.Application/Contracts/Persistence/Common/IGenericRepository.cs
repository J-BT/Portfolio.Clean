using Portfolio.Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Contracts.Persistence.Common;

public interface IGenericRepository<T>
    where T : BaseEntity
{
    Task<IReadOnlyList<T>> GetAsync();
    Task<T> GetAsyncById(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);

}
