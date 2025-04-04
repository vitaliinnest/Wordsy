using MediatR;
using Wordsy.Application.Common.Interfaces;
using Wordsy.Domain.Entities;

namespace Wordsy.Application.Words.Queries.GetAllWords;

public class GetAllWordsQueryHandler(IWordRepository repository) : IRequestHandler<GetAllWordsQuery, List<Word>>
{
	public async Task<List<Word>> Handle(GetAllWordsQuery request, CancellationToken cancellationToken)
	{
		return await repository.GetAllByUserIdAsync(request.UserId, cancellationToken);
	}
}
