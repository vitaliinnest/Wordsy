using Wordsy.Domain.Entities;

namespace Wordsy.Application.Common.Interfaces;

public interface IWordRepository
{
	Task AddAsync(Word word, CancellationToken cancellationToken);
	Task<List<Word>> GetAllByUserIdAsync(Guid userId, CancellationToken cancellationToken);
	Task<Word?> GetByIdAsync(Guid id, Guid userId, CancellationToken cancellationToken);
	Task DeleteAsync(Word word, CancellationToken cancellationToken);
	Task UpdateAsync(Word word, CancellationToken cancellationToken);
}
