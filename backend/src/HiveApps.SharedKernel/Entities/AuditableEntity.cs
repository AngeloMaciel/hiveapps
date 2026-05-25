namespace HiveApps.SharedKernel.Entities;

/// <summary>
/// Represents an entity that stores basic audit information about who created
/// and last updated it.
/// </summary>
public abstract class AuditableEntity : BaseEntity
{
    /// <summary>
    /// Gets the identifier of the user who created the entity, if available.
    /// </summary>
    public Guid? CreatedBy { get; protected set; }

    /// <summary>
    /// Gets the identifier of the user who last updated the entity, if available.
    /// </summary>
    public Guid? UpdatedBy { get; protected set; }

    /// <summary>
    /// Sets the identifier of the user who created the entity.
    /// </summary>
    /// <param name="userId">The identifier of the user who created the entity.</param>
    public void SetCreatedBy(Guid? userId)
    {
        CreatedBy = userId;
    }

    /// <summary>
    /// Sets the identifier of the user who updated the entity and marks the entity
    /// as updated at the specified UTC date and time.
    /// </summary>
    /// <param name="userId">The identifier of the user who updated the entity.</param>
    /// <param name="updatedAt">The UTC date and time when the entity was updated.</param>
    public void SetUpdatedBy(Guid? userId, DateTimeOffset updatedAt)
    {
        UpdatedBy = userId;
        MarkAsUpdated(updatedAt);
    }
}