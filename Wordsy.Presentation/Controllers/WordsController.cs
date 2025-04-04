using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wordsy.Application.Words.Commands.CreateWord;

namespace Wordsy.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WordsController : ControllerBase
{
	private readonly IMediator _mediator;

	public WordsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpPost]
	public async Task<IActionResult> Create([FromBody] CreateWordCommand command, CancellationToken cancellationToken)
	{
		var id = await _mediator.Send(command, cancellationToken);
		return Ok(id);
	}
}
