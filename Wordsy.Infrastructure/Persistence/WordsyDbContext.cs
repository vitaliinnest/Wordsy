using Microsoft.EntityFrameworkCore;
using Wordsy.Domain.Common;
using Wordsy.Domain.Entities;

namespace Wordsy.Infrastructure.Persistence;

public class WordsyDbContext(DbContextOptions<WordsyDbContext> options) : DbContext(options)
{
	public DbSet<Word> Words => Set<Word>();

	public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		foreach (var entry in ChangeTracker.Entries<BaseAuditableEntity>())
		{
			if (entry.State == EntityState.Added)
			{
				entry.Entity.CreatedOn = DateTime.UtcNow;
			}

			if (entry.State == EntityState.Modified)
			{
				entry.Entity.LastModifiedOn = DateTime.UtcNow;
			}
		}

		return await base.SaveChangesAsync(cancellationToken);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(WordsyDbContext).Assembly);
	}
}
