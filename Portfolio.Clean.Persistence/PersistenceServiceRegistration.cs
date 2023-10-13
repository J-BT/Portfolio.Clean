using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Contracts.Persistence.Common;
using Portfolio.Clean.Persistence.DatabaseContext;
using Portfolio.Clean.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence;

public static class PersistenceServiceRegistration
{

    #region Methods
    /// <summary>
    /// Called in the API's Program.cs, this class links the 'Persistence' layer to the 'Api' layer 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {

        services.AddDbContext<PortfolioDatabaseContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("PortfolioDatabaseConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IContactEmailRepository, ContactEmailRepository>();
        services.AddScoped<IPCLogRepository, PCLogRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();


        return services;
    }
    #endregion
}
