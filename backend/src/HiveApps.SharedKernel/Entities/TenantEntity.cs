namespace HiveApps.SharedKernel.Entities;

/// <summary>
/// Represents an auditable entity that belongs to a specific tenant.
/// Tenant-scoped entities must always be accessed in the context of their tenant.
/// </summary>
public abstract class TenantEntity : AuditableEntity
{
    /// <summary>
    /// Gets the identifier of the tenant that owns the entity.
    /// </summary>
    public Guid TenantId { get; protected set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TenantEntity"/> class.
    /// Required by object-relational mappers and serializers.
    /// </summary>
    protected TenantEntity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TenantEntity"/> class
    /// for the specified tenant.
    /// </summary>
    /// <param name="tenantId">The identifier of the tenant that owns the entity.</param>
    protected TenantEntity(Guid tenantId)
    {
        TenantId = tenantId;
    }
}