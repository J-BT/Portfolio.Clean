using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence;

public static class PersistenceServiceRegistration
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        return services;
    }
    #endregion
}
