namespace PortsAndAdapters.Repository.Interfaces;

/// <summary>
/// Order.
/// </summary>
public record Order
{
    /// <summary>
    /// Order id.
    /// </summary>
    public long Id { get; init; }

    /// <summary>
    /// Order date.
    /// </summary>
    public DateTime OrderDate { get; init; }

    /// <summary>
    /// Items in order.
    /// </summary>
    public ICollection<OrderItem> Items { get; init; } = Array.Empty<OrderItem>();
}
