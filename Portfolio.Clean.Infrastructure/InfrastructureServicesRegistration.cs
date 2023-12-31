﻿using Portfolio.Clean.Application.Contracts.Email;
using Portfolio.Clean.Application.Models.Email;
using Portfolio.Clean.Infrastructure.EmailService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Clean.Application.Contracts.Logging;
using Portfolio.Clean.Infrastructure.Logging;

namespace Portfolio.Clean.Infrastructure;

public static class InfrastructureServicesRegistration
{
    #region Methods
    /// <summary>
    /// Called in the API's Program.cs, this class links the 'Infrastructure' layer to the 'Api' layer 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastuctureServices(this IServiceCollection services,
		IConfiguration configuration)
	{
        //Email config here
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
		services.AddTransient<IEmailSender, EmailSender>();
		services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));


        return services;
	}
	#endregion
}