using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Wordsy.Presentation;

public static class DependencyInjection
{
	public static IServiceCollection AddPresentation(this IServiceCollection services)
	{
		services.AddControllers();
		
		services
			.AddFluentValidationAutoValidation()
			.AddFluentValidationClientsideAdapters();

		return services;
	}
}
