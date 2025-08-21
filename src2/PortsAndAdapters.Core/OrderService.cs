using PortsAndAdapters.Core.Mappers;
using PortsAndAdapters.Environment.Interfaces;
using PortsAndAdapters.Repository.Interfaces;
using PortsAndAdapters.Rest.Interfaces;
using Order = PortsAndAdapters.Rest.Interfaces.Order;

namespace PortsAndAdapters.Core;

/// <summary>
/// Order service.
/// </summary>
public class OrderService : IOrderService
{
    private readonly IDateTime _dateTime;
    private readonly IOrderRepository _orderRepository;
    private OrderMapper? _orderMapper;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dateTime">Date and time provider.</param>
    /// <param name="orderRepository">Order repository.</param>
    public OrderService(
        IDateTime dateTime,
        IOrderRepository orderRepository)
    {
        _dateTime = dateTime;
        _orderRepository = orderRepository;
    }

    private OrderMapper OrderMapper =>
        LazyInitializer.EnsureInitialized(
            ref _orderMapper,
            () => new OrderMapper());

    /// <inheritdoc />
    public Task PlaceOrderAsync(NewOrder order)
    {
        ArgumentNullException.ThrowIfNull(order);
        var now = _dateTime.UtcNow;
        var orderRepo = OrderMapper.ToRepo(order, now);
        return _orderRepository.AddOrderAsync(orderRepo);
    }

    /// <inheritdoc />
    public async Task<Order?> GetOrderAsync(int orderId)
    {
        var orderRepo = await _orderRepository
            .GetOrderAsync(orderId)
            .ConfigureAwait(false);

        if (orderRepo == null)
            return null;

        var orderRest = OrderMapper.ToRest(orderRepo);
        return orderRest;
    }
}
