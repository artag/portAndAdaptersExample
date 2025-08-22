using RestDto = PortsAndAdapters.Rest.Interfaces;
using RepoDto = PortsAndAdapters.Repository.Interfaces;

namespace PortsAndAdapters.Mappers.Interfaces;

/// <summary>
/// Order mapper.
/// </summary>
public interface IOrderMapper
{
    /// <summary>
    /// Map <see cref="RestDto.NewOrder"/> to <see cref="RepoDto.Order"/>.
    /// </summary>
    /// <param name="order">New order from REST.</param>
    /// <param name="orderDate">Order date and time.</param>
    /// <returns>Order in repository.</returns>
    RepoDto.Order MapToOrderRepo(RestDto.NewOrder order, DateTime orderDate);

    /// <summary>
    /// Map <see cref="RepoDto.Order"/> to <see cref="RestDto.Order"/>.
    /// </summary>
    /// <param name="order">Order in repository.</param>
    /// <returns>Order in REST.</returns>
    RestDto.Order MapToOrderRest(RepoDto.Order order);
}
