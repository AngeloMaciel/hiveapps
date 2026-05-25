namespace HiveApps.SharedKernel.Time;

/// <summary>
/// Provides access to the current date and time in UTC.
/// This abstraction allows time-dependent behavior to be tested consistently.
/// </summary>
public interface IDateTimeProvider
{
    /// <summary>
    /// Gets the current UTC date and time.
    /// </summary>
    DateTimeOffset UtcNow { get; }
}