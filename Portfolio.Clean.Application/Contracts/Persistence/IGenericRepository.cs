﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Contracts.Persistence
{
    public interface IGenericRepository<T>
        where T : class
    {
        Task<T> GetAsync();
        Task<T> GetAsyncById(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}
