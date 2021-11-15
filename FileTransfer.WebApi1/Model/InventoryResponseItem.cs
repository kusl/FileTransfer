namespace FileTransfer.WebApi1.Model;

public class InventoryResponseItem
{
    public string? Style { get; set; }
    public string? Sku { get; set; }
    public int? ReqQty { get; set; }
    public DateTime? ReqDate { get; set; }
    public bool? IsManufacturedItem { get; set; }
    public int? OnHandQty { get; set; }
    public int? BackOrderQty { get; set; }
    public DateTime? BackOrderDate { get; set; }
    public int? FutureQty { get; set; }
    public DateTime? FutureDate { get; set; }
}
