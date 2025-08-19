using PortsAndAdapters.Application.Model;

namespace PortsAndAdapters.Application.PortsPrimary;

/// <summary>
/// Order service.
/// </summary>
public interface IOrderService
{
    /// <summary>
    /// Place order.
    /// </summary>
    /// <param name="order">Order.</param>
    /// <returns>Task.</returns>
    Task PlaceOrderAsync(Order order);

    /// <summary>
    /// Get order by id.
    /// </summary>
    /// <param name="orderId">Order id.</param>
    /// <returns>Order.</returns>
    Task<Order?> GetOrderAsync(int orderId);
}
