namespace Wordsy.Domain.Common;

public abstract class BaseUserOwnedEntity : BaseEntity
{
	public Guid UserId { get; set; }
}
