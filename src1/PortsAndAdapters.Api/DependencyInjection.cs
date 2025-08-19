using PortsAndAdapters.Application.ApplicationCore;
using PortsAndAdapters.Application.PortsPrimary;
using PortsAndAdapters.Application.PortsSecondary;
using PortsAndAdapters.Infrastructure.Repositories;

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
        services.AddMemoryCache();
        services.AddScoped<IOrderRepository, InMemoryOrderRepository>();
        services.AddScoped<IOrderService, OrderService>();

        return services;
    }
}
