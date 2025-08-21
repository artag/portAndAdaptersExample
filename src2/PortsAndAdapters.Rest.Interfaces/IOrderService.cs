namespace PortsAndAdapters.Rest.Interfaces;

/// <summary>
/// Order service.
/// </summary>
public interface IOrderService
{
    /// <summary>
    /// Place order.
    /// </summary>
    /// <param name="order">New order.</param>
    /// <returns>Task.</returns>
    Task PlaceOrderAsync(NewOrder order);

    /// <summary>
    /// Get order by id.
    /// </summary>
    /// <param name="orderId">Order id.</param>
    /// <returns>Order.</returns>
    Task<Order?> GetOrderAsync(int orderId);
}
