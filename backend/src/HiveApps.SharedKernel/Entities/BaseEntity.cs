namespace HiveApps.SharedKernel.Entities;

/// <summary>
/// Represents the base class for all domain entities in the HiveApps system.
/// Provides a unique identifier and basic creation/update timestamps.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Gets the unique identifier of the entity.
    /// </summary>
    public Guid Id { get; protected set; } = Guid.NewGuid();

    /// <summary>
    /// Gets the UTC date and time when the entity was created.
    /// </summary>
    public DateTimeOffset CreatedAt { get; protected set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Gets the UTC date and time when the entity was last updated, if applicable.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; protected set; }

    /// <summary>
    /// Marks the entity as updated at the specified UTC date and time.
    /// </summary>
    /// <param name="updatedAt">The UTC date and time when the entity was updated.</param>
    public void MarkAsUpdated(DateTimeOffset updatedAt)
    {
        UpdatedAt = updatedAt;
    }
}