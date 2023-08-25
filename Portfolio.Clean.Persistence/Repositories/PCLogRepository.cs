using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Domain;
using Portfolio.Clean.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.Repositories;

public class PCLogRepository : GenericRepository<PCLog>, IPCLogRepository
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public PCLogRepository(PortfolioDatabaseContext context) 
        : base(context)
    {
    }
    #endregion

    #region Methods

    #endregion

}
