namespace PortsAndAdapters.Application.Model;

/// <summary>
/// Order.
/// </summary>
public class Order
{
    /// <summary>
    /// Order id.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Order date.
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// Items in order.
    /// </summary>
    public ICollection<OrderItem> Items { get; init; } = Array.Empty<OrderItem>();
}
