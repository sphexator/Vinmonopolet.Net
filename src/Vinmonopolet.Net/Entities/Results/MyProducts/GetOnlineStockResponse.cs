using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetOnlineStockResponse
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("stock")]
	public List<Stock> Stock { get; set; } = new List<Stock>();
}

public class Stock
{
    [JsonPropertyName("storeId")]
    public string StoreId { get; set; } = string.Empty;

    [JsonPropertyName("storeStock")]
    public int? StoreStock { get; set; } = null;

    [JsonPropertyName("lastChanged")]
    public LastChanged LastChanged { get; set; } = new LastChanged();
}