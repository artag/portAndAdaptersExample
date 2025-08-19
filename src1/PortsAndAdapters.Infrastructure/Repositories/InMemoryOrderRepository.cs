using Microsoft.Extensions.Caching.Memory;
using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsSecondary;

namespace PortsAndAdapters.Infrastructure.Repositories;

/// <summary>
/// Local in-memory repository.
/// </summary>
public class InMemoryOrderRepository : IOrderRepository
{
    private readonly IMemoryCache _cache;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="cache">Local in-memory cache.</param>
    public InMemoryOrderRepository(IMemoryCache cache)
    {
        _cache = cache;
    }

    /// <inheritdoc />
    public Task AddOrderAsync(Order? order)
    {
        if (order == null)
            return Task.CompletedTask;

        _cache.Set(order.Id, order);
        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task<Order?> GetOrderAsync(int orderId)
    {
        _cache.TryGetValue(orderId, out Order? order);
        return Task.FromResult(order);
    }
}
