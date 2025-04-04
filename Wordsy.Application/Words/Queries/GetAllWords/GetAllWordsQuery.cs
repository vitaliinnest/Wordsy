using MediatR;
using Wordsy.Domain.Entities;

namespace Wordsy.Application.Words.Queries.GetAllWords;

public record GetAllWordsQuery(Guid UserId) : IRequest<List<Word>>;
