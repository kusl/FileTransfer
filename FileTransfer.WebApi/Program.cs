var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateTime.Now.AddDays(index),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

//app.MapGet("/inventorylookupadvanced", () =>
//{
//    var inventory = Enumerable.Range(1, 5).Select(index =>
//   new InventoryResponseItem
//   (
//       DateTime.Now.AddDays(index),
//       Random.Shared.Next(-20, 55),
//       summaries[Random.Shared.Next(summaries.Length)]
//   ))
//    .ToArray();
//    return inventory;
//})
//.WithName("GetAdvancedInventory");

//internal class InventoryRequest
//{
//    public string? Style { get; set; }
//    public string? Sku { get; set; }
//    public int? Quantity { get; set; }
//    public DateTime? DateAvailable { get; set; }
//}

//internal class InventoryResponseItem
//{
//    public string? Style { get; set; }
//    public string? Sku { get; set; }
//    public int? ReqQty { get; set; }
//    public DateTime? ReqDate { get; set; }
//    public bool? IsManufacturedItem { get; set; }
//    public int? OnHandQty { get; set; }
//    public int? BackOrderQty { get; set; }
//    public DateTime? BackOrderDate { get; set; }
//    public int? FutureQty { get; set; }
//    public DateTime? FutureDate { get; set; }
//}

//internal class InventoryResponse
//{
//    public InventoryResponseItem[] Items { get; set; }
//}
