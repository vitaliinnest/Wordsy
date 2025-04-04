using MediatR;
using Wordsy.Domain.Entities;
using Wordsy.Application.Common.Interfaces;

namespace Wordsy.Application.Words.Commands.CreateWord;

public class CreateWordCommandHandler(IWordRepository repository) : IRequestHandler<CreateWordCommand, Guid>
{
	public async Task<Guid> Handle(CreateWordCommand request, CancellationToken cancellationToken)
	{
		var word = new Word
		{
			Text = request.Text,
			Translation = request.Translation,
			UserId = request.UserId
		};

		await repository.AddAsync(word, cancellationToken);

		return word.Id;
	}
}
