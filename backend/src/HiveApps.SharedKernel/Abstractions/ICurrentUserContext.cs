namespace HiveApps.SharedKernel.Abstractions;

/// <summary>
/// Provides information about the user associated with the current execution context.
/// </summary>
public interface ICurrentUserContext
{
    /// <summary>
    /// Gets the identifier of the current user, if authenticated.
    /// </summary>
    Guid? UserId { get; }

    /// <summary>
    /// Gets the role assigned to the current user, if available.
    /// </summary>
    string? Role { get; }

    /// <summary>
    /// Gets a value indicating whether the current execution context has an authenticated user.
    /// </summary>
    bool IsAuthenticated { get; }
}