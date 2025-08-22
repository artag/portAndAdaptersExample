using PortsAndAdapters.Core;
using PortsAndAdapters.Environment;
using PortsAndAdapters.Environment.Interfaces;
using PortsAndAdapters.Mappers.Interfaces;
using PortsAndAdapters.Mappers.Mapperly;
using PortsAndAdapters.Repository.InMemory;
using PortsAndAdapters.Repository.Interfaces;
using PortsAndAdapters.Rest.Interfaces;
using OrderMapper = PortsAndAdapters.Mappers.Mapperly.OrderMapper;

namespace PortsAndAdapters.Api;

/// <summary>
/// Dependency injection.
/// </summary>
internal static class DependencyInjection
{
    /// <summary>
    /// Register services in application DI.
    /// </summary>
    /// <param name="services">Application services.</param>
    /// <returns>Application services.</returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<IDateTime, DateTimeService>();
        services.AddSingleton<IOrderRepository, InMemoryOrderRepository>();
        services.AddSingleton<IOrderService, OrderService>();

        services.AddSingleton<IOrderMapper, OrderMapper>();
        services.AddSingleton<IMappers, DtoMappers>();

        return services;
    }
}
