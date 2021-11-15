namespace FileTransfer.WebApi1.Model;

public class InventoryResponse
{
    public InventoryResponse(InventoryResponseItem[] items)
    {
        Items = items;
    }

    public InventoryResponseItem[] Items { get; set; } = Array.Empty<InventoryResponseItem>();
}
