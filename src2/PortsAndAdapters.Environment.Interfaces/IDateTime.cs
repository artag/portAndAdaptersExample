namespace PortsAndAdapters.Environment.Interfaces;

/// <summary>
/// Date and time provider.
/// </summary>
public interface IDateTime
{
    /// <summary>
    /// Gets a <see cref="DateTime"/> object that is set to the current date
    /// and time on this computer, expressed as the Coordinated Universal Time (UTC).
    /// </summary>
    DateTime UtcNow { get; }
}
