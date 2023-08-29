using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Contracts.Persistence.Common;
using Portfolio.Clean.Persistence.DatabaseContext;
using Portfolio.Clean.Persistence.Repositories;
using Portfolio.Clean.Persistence.UserSecret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence;

public static class PersistenceServiceRegistration
{

    #region Attributes & Accessors
    private static string ConnectionString { get; set; } = string.Empty;
    public static DatabaseUserSecret DbConfig { get; set; } = new();
    #endregion

    #region Constructors

    #endregion

    #region Methods
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration, IOptions<DatabaseUserSecret> databaseUserSecret)
    {
        DbConfig = databaseUserSecret.Value; //Getting Usersecret infos

        ConnectionString =$@"Server={DbConfig.HostName}; Database={DbConfig.DatabaseName}; Trusted_Connection=True;
        Integrated security=false; Encrypt=False; User ID={DbConfig.UserName}; Password={DbConfig.UserPassword};";

        services.AddDbContext<PortfolioDatabaseContext>(options =>
        {
            //options.UseSqlServer(configuration.GetConnectionString("PortfolioDatabaseConnectionString"));
            options.UseSqlServer(ConnectionString);
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IContactEmailRepository, ContactEmailRepository>();
        services.AddScoped<IPCLogRepository, PCLogRepository>();
        services.AddScoped<ITechnologyRepository, TechnologyRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();


        return services;
    }
    #endregion
}
