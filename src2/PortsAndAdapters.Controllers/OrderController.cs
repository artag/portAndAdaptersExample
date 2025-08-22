using Microsoft.AspNetCore.Mvc;
using PortsAndAdapters.Rest.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace PortsAndAdapters.Controllers;

/// <summary>
/// API. Order controller.
/// </summary>
[SuppressMessage(
    "Maintainability",
    "CA1515:Consider making public types internal",
    Justification = "Controller must have public visibility.")]
[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="orderService">Order service.</param>
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    /// <summary>
    /// Place order.
    /// </summary>
    /// <param name="order">Order.</param>
    /// <returns>Result of the operation.</returns>
    [HttpPost]
    public async Task<IActionResult> PlaceOrderAsync(NewOrder? order)
    {
        if (order == null)
            return BadRequest();

        await _orderService.PlaceOrderAsync(order).ConfigureAwait(false);
        return Ok();
    }

    /// <summary>
    /// Get order by id.
    /// </summary>
    /// <param name="orderId">Order id.</param>
    /// <returns>Result of the operation.</returns>
    [HttpGet("{orderId}")]
    public async Task<IActionResult> GetOrderAsync(int orderId)
    {
        var order = await _orderService.GetOrderAsync(orderId).ConfigureAwait(false);
        return order is null
            ? NotFound()
            : Ok(order);
    }
}
