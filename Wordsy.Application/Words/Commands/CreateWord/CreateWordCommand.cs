using MediatR;

namespace Wordsy.Application.Words.Commands.CreateWord;

public record CreateWordCommand(Guid UserId, string Text, string Translation) : IRequest<Guid>;
