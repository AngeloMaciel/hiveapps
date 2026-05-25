namespace HiveApps.SharedKernel.Abstractions;

/// <summary>
/// Provides information about the tenant associated with the current execution context.
/// </summary>
public interface ITenantContext
{
    /// <summary>
    /// Gets the identifier of the current tenant, if available.
    /// </summary>
    Guid? TenantId { get; }

    /// <summary>
    /// Gets a value indicating whether the current execution context is associated with a tenant.
    /// </summary>
    bool HasTenant { get; }
}