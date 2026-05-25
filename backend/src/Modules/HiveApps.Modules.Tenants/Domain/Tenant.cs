using HiveApps.SharedKernel.Entities;
using HiveApps.SharedKernel.Text;

namespace HiveApps.Modules.Tenants.Tenants.Domain;

/// <summary>
/// Represents a tenant, which is an isolated workspace or customer environment
/// inside the HiveApps platform.
/// </summary>
public sealed class Tenant : AuditableEntity
{
    /// <summary>
    /// Gets the tenant display name.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the tenant unique slug used for friendly identification.
    /// </summary>
    public string Slug { get; private set; }

    /// <summary>
    /// Gets the current lifecycle status of the tenant.
    /// </summary>
    public TenantStatus Status { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Tenant"/> class.
    /// Required by object-relational mappers.
    /// </summary>
    private Tenant()
    {
        Name = string.Empty;
        Slug = string.Empty;
        Status = TenantStatus.Active;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Tenant"/> class.
    /// </summary>
    /// <param name="name">The tenant display name.</param>
    public Tenant(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Tenant name cannot be empty.", nameof(name));
        }

        Name = name.Trim();
        Slug = SlugGenerator.Generate(Name);
        Status = TenantStatus.Active;
    }

    /// <summary>
    /// Updates the tenant display name and regenerates the slug.
    /// </summary>
    /// <param name="name">The new tenant display name.</param>
    public void Rename(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Tenant name cannot be empty.", nameof(name));
        }

        Name = name.Trim();
        Slug = SlugGenerator.Generate(Name);
    }

    /// <summary>
    /// Suspends the tenant.
    /// </summary>
    public void Suspend()
    {
        if (Status == TenantStatus.Archived)
        {
            throw new InvalidOperationException("Archived tenants cannot be suspended.");
        }

        Status = TenantStatus.Suspended;
    }

    /// <summary>
    /// Reactivates the tenant.
    /// </summary>
    public void Activate()
    {
        if (Status == TenantStatus.Archived)
        {
            throw new InvalidOperationException("Archived tenants cannot be reactivated.");
        }

        Status = TenantStatus.Active;
    }

    /// <summary>
    /// Archives the tenant.
    /// </summary>
    public void Archive()
    {
        Status = TenantStatus.Archived;
    }
}