using PortsAndAdapters.Core;
using PortsAndAdapters.Environment;
using PortsAndAdapters.Environment.Interfaces;
using PortsAndAdapters.Repository.InMemory;
using PortsAndAdapters.Repository.Interfaces;
using PortsAndAdapters.Rest.Interfaces;

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

        return services;
    }
}
