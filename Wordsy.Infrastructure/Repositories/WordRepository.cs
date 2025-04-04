using Microsoft.EntityFrameworkCore;
using Wordsy.Application.Common.Interfaces;
using Wordsy.Domain.Entities;
using Wordsy.Infrastructure.Persistence;

namespace Wordsy.Infrastructure.Repositories;

public class WordRepository(WordsyDbContext context) : IWordRepository
{
	public async Task AddAsync(Word word, CancellationToken cancellationToken)
	{
		await context.Words.AddAsync(word, cancellationToken);
		await context.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<Word>> GetAllByUserIdAsync(Guid userId, CancellationToken cancellationToken)
	{
		return await context.Words
			.Where(w => w.UserId == userId)
			.OrderByDescending(w => w.CreatedOn)
			.ToListAsync(cancellationToken);
	}

	public async Task<Word?> GetByIdAsync(Guid id, Guid userId, CancellationToken cancellationToken)
	{
		return await context.Words
			.FirstOrDefaultAsync(w => w.Id == id && w.UserId == userId, cancellationToken);
	}

	public async Task DeleteAsync(Word word, CancellationToken cancellationToken)
	{
		context.Words.Remove(word);
		await context.SaveChangesAsync(cancellationToken);
	}

	public async Task UpdateAsync(Word word, CancellationToken cancellationToken)
	{
		context.Words.Update(word);
		await context.SaveChangesAsync(cancellationToken);
	}
}
