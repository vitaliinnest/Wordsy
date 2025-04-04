using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wordsy.Application.Common.Interfaces;
using Wordsy.Infrastructure.Persistence;
using Wordsy.Infrastructure.Repositories;

namespace Wordsy.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<WordsyDbContext>(options =>
			options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

		services.AddScoped<IWordRepository, WordRepository>();

		return services;
	}
}
