namespace FileTransfer.WebApi1.Model;

public class InventoryRequest
{
    public string? Style { get; set; }
    public string? Sku { get; set; }
    public int? Quantity { get; set; }
    public DateTime? DateAvailable { get; set; }
}
