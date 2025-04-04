using FluentValidation;

namespace Wordsy.Application.Words.Commands.CreateWord;

public class CreateWordCommandValidator : AbstractValidator<CreateWordCommand>
{
	public CreateWordCommandValidator()
	{
		RuleFor(x => x.UserId)
			.NotEmpty().WithMessage("UserId is required");

		RuleFor(x => x.Text)
			.NotEmpty().WithMessage("Text is required")
			.MaximumLength(100).WithMessage("Text must be less than 100 characters");

		RuleFor(x => x.Translation)
			.NotEmpty().WithMessage("Translation is required")
			.MaximumLength(100).WithMessage("Translation must be less than 100 characters");
	}
}
