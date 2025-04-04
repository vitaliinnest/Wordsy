using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wordsy.Application.Words.Commands.CreateWord;
using Wordsy.Application.Words.Queries.GetAllWords;

namespace Wordsy.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WordsController(IMediator mediator) : ControllerBase
{
	[HttpPost]
	public async Task<IActionResult> Create([FromBody] CreateWordCommand command, CancellationToken cancellationToken)
	{
		var id = await mediator.Send(command, cancellationToken);
		return Ok(id);
	}

	[HttpGet]
	public async Task<IActionResult> GetAll([FromQuery] Guid userId, CancellationToken cancellationToken)
	{
		var words = await mediator.Send(new GetAllWordsQuery(userId), cancellationToken);
		return Ok(words);
	}
}
