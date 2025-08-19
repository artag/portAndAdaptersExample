using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsPrimary;
using PortsAndAdapters.Application.PortsSecondary;

namespace PortsAndAdapters.Application.ApplicationCore;

/// <summary>
/// Order service.
/// </summary>
public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="orderRepository"></param>
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    /// <inheritdoc />
    public Task PlaceOrderAsync(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);
        order.OrderDate = DateTime.UtcNow;
        return _orderRepository.AddOrderAsync(order);
    }

    /// <inheritdoc />
    public Task<Order?> GetOrderAsync(int orderId)
    {
        return _orderRepository.GetOrderAsync(orderId);
    }
}
