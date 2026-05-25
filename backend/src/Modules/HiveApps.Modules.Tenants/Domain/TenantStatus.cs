namespace HiveApps.Modules.Tenants.Tenants.Domain;

/// <summary>
/// Represents the lifecycle status of a tenant in the HiveApps platform.
/// </summary>
public enum TenantStatus
{
    /// <summary>
    /// The tenant is active and can be used normally.
    /// </summary>
    Active = 1,

    /// <summary>
    /// The tenant is temporarily suspended and cannot access protected features.
    /// </summary>
    Suspended = 2,

    /// <summary>
    /// The tenant has been archived and is no longer available for regular use.
    /// </summary>
    Archived = 3
}