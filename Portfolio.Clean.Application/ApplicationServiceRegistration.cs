using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application;

public static class ApplicationServiceRegistration
{

	#region Methods
	/// <summary>
	/// Called in the API's Program.cs, this class links the 'Application' layer to the 'Api' layer 
	/// </summary>
	/// <param name="services"></param>
	/// <returns></returns>
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		// Cf: « services.AddMediatR(Assembly.GetExecutingAssembly()); » doesn't work since MediatR@12.0.1

		return services;
    }

	#endregion
}
