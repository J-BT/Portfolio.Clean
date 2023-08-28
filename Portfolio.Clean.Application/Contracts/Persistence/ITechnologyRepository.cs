﻿using Portfolio.Clean.Application.Contracts.Persistence.Common;
using Portfolio.Clean.Domain;

namespace Portfolio.Clean.Application.Contracts.Persistence;

public interface ITechnologyRepository : IGenericRepository<Technology>
{
    Task<bool> IsTechnologyUnique(string technoName);
    Task<Technology> GetTechnologyWithDetails(string technoName);
}
