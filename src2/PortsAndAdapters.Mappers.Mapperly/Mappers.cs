using PortsAndAdapters.Mappers.Interfaces;

namespace PortsAndAdapters.Mappers.Mapperly;

/// <summary>
/// DTO mappers.
/// </summary>
public class DtoMappers : IMappers
{
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="orderMapper">Order mapper.</param>
    public DtoMappers(IOrderMapper orderMapper)
    {
        OrderMapper = orderMapper;
    }

    /// <inheritdoc />
    public IOrderMapper OrderMapper { get; }
}
