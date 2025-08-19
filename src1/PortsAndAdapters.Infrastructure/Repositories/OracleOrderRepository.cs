using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsSecondary;

namespace PortsAndAdapters.Infrastructure.Repositories;

/// <summary>
/// Dummy (not implemented) repository in Oracle.
/// </summary>
public class OracleOrderRepository : IOrderRepository
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
