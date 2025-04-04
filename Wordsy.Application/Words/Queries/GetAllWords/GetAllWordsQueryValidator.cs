using FluentValidation;

namespace Wordsy.Application.Words.Queries.GetAllWords;

public class GetAllWordsQueryValidator : AbstractValidator<GetAllWordsQuery>
{
	public GetAllWordsQueryValidator()
	{
		RuleFor(x => x.UserId)
			.NotEmpty().WithMessage("UserId is required.");
	}
}
