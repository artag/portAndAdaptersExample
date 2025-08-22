using PortsAndAdapters.Mappers.Interfaces;
using Riok.Mapperly.Abstractions;
using RepoDto = PortsAndAdapters.Repository.Interfaces;
using RestDto = PortsAndAdapters.Rest.Interfaces;

namespace PortsAndAdapters.Mappers.Mapperly;

/// <summary>
/// Order mapper.
/// </summary>
[Mapper]
public partial class OrderMapper : IOrderMapper
{
    /// <inheritdoc />
    [MapperIgnoreTarget(nameof(RepoDto.Order.Id))]
    public partial RepoDto.Order MapToOrderRepo(RestDto.NewOrder order, DateTime orderDate);

    /// <inheritdoc />
    public partial RestDto.Order MapToOrderRest(RepoDto.Order order);
}
