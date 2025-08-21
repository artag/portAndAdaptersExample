using Riok.Mapperly.Abstractions;
using NewOrderRest = PortsAndAdapters.Rest.Interfaces.NewOrder;
using OrderRest = PortsAndAdapters.Rest.Interfaces.Order;
using OrderRepo = PortsAndAdapters.Repository.Interfaces.Order;

namespace PortsAndAdapters.Core.Mappers;

/// <summary>
/// Order mapper.
/// </summary>
[Mapper]
public partial class OrderMapper
{
    /// <summary>
    /// Map <see cref="NewOrderRest"/> to <see cref="OrderRepo"/>.
    /// </summary>
    /// <param name="order">New order from REST.</param>
    /// <param name="orderDate">Order date and time.</param>
    /// <returns>Order in repository.</returns>
#pragma warning disable RMG012 // Source member Id was not found for target member
    public partial OrderRepo ToRepo(NewOrderRest order, DateTime orderDate);
#pragma warning restore RMG012 // Source member Id was not found for target member

    /// <summary>
    /// Map <see cref="OrderRepo"/> to <see cref="OrderRest"/>.
    /// </summary>
    /// <param name="order">Order in repository.</param>
    /// <returns>Order in REST.</returns>
    public partial OrderRest ToRest(OrderRepo order);
}
