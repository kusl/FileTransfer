using FileTransfer.WebApi1.Model;
using Microsoft.AspNetCore.Mvc;

namespace FileTransfer.WebApi1.Controllers;

[ApiController]
[Route("[controller]")]
public class InventoryController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public InventoryController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetInventory")]
    public InventoryResponse Get()
    {
        _logger.LogInformation("begin get inventory forecast");

        var items = Enumerable.Range(1, 5).Select(index => new InventoryResponseItem
        {
            Style = "dummy response",
            Sku = "dummy response",
            ReqQty = 500,
            ReqDate = DateTime.UtcNow.AddDays(7),
            IsManufacturedItem = false,
            OnHandQty = 299,
            BackOrderQty = 54,
            BackOrderDate = DateTime.UtcNow.AddDays(30),
            FutureQty = 42000,
            FutureDate = DateTime.UtcNow.AddDays(45),
        })
        .ToArray();
        return new InventoryResponse(items);
    }
}
