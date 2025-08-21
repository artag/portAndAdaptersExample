using PortsAndAdapters.Environment.Interfaces;

namespace PortsAndAdapters.Environment;

/// <summary>
/// Date and time provider service.
/// </summary>
public class DateTimeService : IDateTime
{
    /// <inheritdoc />
    public DateTime UtcNow => DateTime.UtcNow;
}
