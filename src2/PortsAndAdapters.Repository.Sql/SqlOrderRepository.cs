using PortsAndAdapters.Repository.Interfaces;

namespace PortsAndAdapters.Repository.Sql;

/// <summary>
/// Dummy (not implemented) repository in some SQL server.
/// </summary>
public class SqlOrderRepository : IOrderRepository
{
    /// <inheritdoc />
    public Task AddOrderAsync(Order? order)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<Order?> GetOrderAsync(int orderId)
    {
        throw new NotImplementedException();
    }
}
