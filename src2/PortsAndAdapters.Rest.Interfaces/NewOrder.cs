namespace PortsAndAdapters.Rest.Interfaces;

/// <summary>
/// New order.
/// </summary>
public class NewOrder
{
    /// <summary>
    /// Items in order.
    /// </summary>
    public ICollection<OrderItem> Items { get; init; } = Array.Empty<OrderItem>();
}
