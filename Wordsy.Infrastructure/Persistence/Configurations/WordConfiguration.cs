using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Wordsy.Domain.Entities;

namespace Wordsy.Infrastructure.Persistence.Configurations;

public class WordConfiguration : IEntityTypeConfiguration<Word>
{
	public void Configure(EntityTypeBuilder<Word> builder)
	{
		builder
			.Property(w => w.Text)
			.IsRequired()
			.HasMaxLength(100);

		builder
			.Property(w => w.Translation)
			.IsRequired()
			.HasMaxLength(100);
	}
}
