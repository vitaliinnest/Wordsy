using Microsoft.Extensions.DependencyInjection;

namespace Wordsy.Application;

public static class DependencyInjection
{
	public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
	{
		return serviceCollection;
	}
}
