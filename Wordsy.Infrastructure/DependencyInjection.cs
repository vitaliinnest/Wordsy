using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wordsy.Infrastructure.Persistence;

namespace Wordsy.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
	{
		serviceCollection.AddDbContext<WordsyDbContext>(options =>
			options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

		return serviceCollection;
	}
}
