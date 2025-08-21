using PortsAndAdapters.Repository.Interfaces;

namespace PortsAndAdapters.Repository.InMemory;

/// <summary>
/// Local in-memory repository.
/// </summary>
public class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<long, Order> _db = new();

    /// <inheritdoc />
    public Task AddOrderAsync(Order? order)
    {
        if (order == null)
            return Task.CompletedTask;

        var id = GetNewId();
        order = order with { Id = id };
        _db.Add(order.Id, order);

        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task<Order?> GetOrderAsync(int orderId)
    {
        _db.TryGetValue(orderId, out var order);
        return Task.FromResult(order);
    }

    private long GetNewId()
    {
        var maxId = _db.Count < 1
            ? 0
            : _db.Select(p => p.Key).Max();

        return maxId + 1;
    }
}
