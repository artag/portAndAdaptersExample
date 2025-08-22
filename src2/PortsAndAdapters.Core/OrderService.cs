using PortsAndAdapters.Environment.Interfaces;
using PortsAndAdapters.Mappers.Interfaces;
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
    private readonly IMappers _mappers;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dateTime">Date and time provider.</param>
    /// <param name="orderRepository">Order repository.</param>
    /// <param name="mappers">Dto mappers.</param>
    public OrderService(
        IDateTime dateTime,
        IOrderRepository orderRepository,
        IMappers mappers)
    {
        _dateTime = dateTime;
        _orderRepository = orderRepository;
        _mappers = mappers;
    }

    /// <inheritdoc />
    public Task PlaceOrderAsync(NewOrder order)
    {
        ArgumentNullException.ThrowIfNull(order);
        var now = _dateTime.UtcNow;
        var orderRepo = _mappers.OrderMapper.MapToOrderRepo(order, now);
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

        var orderRest = _mappers.OrderMapper.MapToOrderRest(orderRepo);
        return orderRest;
    }
}
