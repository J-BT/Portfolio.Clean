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

		return services;
	}
	#endregion
}