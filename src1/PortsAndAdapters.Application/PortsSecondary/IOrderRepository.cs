using PortsAndAdapters.Application.Model;

namespace PortsAndAdapters.Application.PortsSecondary;

/// <summary>
/// Order repository.
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// Add order to the repository.
    /// </summary>
    /// <param name="order">Order to add.</param>
    /// <returns>Task.</returns>
    Task AddOrderAsync(Order? order);

    /// <summary>
    /// Get order by id.<br/>
    /// Return null if order is not found.
    /// </summary>
    /// <param name="orderId">Order id.</param>
    /// <returns>Order.</returns>
    Task<Order?> GetOrderAsync(int orderId);
}
