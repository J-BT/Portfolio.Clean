using Portfolio.Clean.Application.Contracts.Email;
using Portfolio.Clean.Application.Models.Email;
using Portfolio.Clean.Infrastructure.EmailService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Portfolio.Clean.Infrastructure;

public static class InfrastructureServicesRegistration
{

	#region Attributes & Accessors

	#endregion

	#region Methods
	public static IServiceCollection ConfigureInfrastuctureServices(this IServiceCollection services,
		IConfiguration configuration)
	{
        //Email config here
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
		services.AddTransient<IEmailSender, EmailSender>();


        return services;
	}
	#endregion
}