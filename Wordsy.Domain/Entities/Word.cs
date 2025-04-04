using Wordsy.Domain.Common;

namespace Wordsy.Domain.Entities;

public class Word : BaseUserOwnedEntity
{
	public string Text { get; set; } = default!;
	public string Translation { get; set; } = default!;
}
