namespace Wordsy.Domain.Common;

public abstract class BaseAuditableEntity : BaseUserOwnedEntity
{
	public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
	public DateTime? LastModifiedOn { get; set; }
}
