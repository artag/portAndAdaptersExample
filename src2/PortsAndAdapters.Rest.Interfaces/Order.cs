namespace PortsAndAdapters.Rest.Interfaces;

/// <summary>
/// Order.
/// </summary>
public class Order : NewOrder
{
    /// <summary>
    /// Order id.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Order date.
    /// </summary>
    public DateTime OrderDate { get; set; }
}
