using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results;

public class Sales
{
    [JsonPropertyName("productId")]
    public string ProductId { get; set; } = string.Empty;

    [JsonPropertyName("salesVolume")]
    public decimal? SalesVolume { get; set; } = null;

    [JsonPropertyName("salesQuantity")]
    public int? SalesQuantity { get; set; } = null;

    [JsonPropertyName("lastChanged")]
    public LastChanged LastChanged { get; set; } = new();
}

public class StoreSales
{
    [JsonPropertyName("storeId")]
    public string StoreId { get; set; } = string.Empty;

    [JsonPropertyName("sales")]
    public List<Sales> Sales { get; set; } = [];
}

public class ProductGetMonthlySalesResponse
{
    [JsonPropertyName("salesMonth")]
    public string SalesMonth { get; set; } = string.Empty;

    [JsonPropertyName("storeSales")]
    public List<StoreSales> StoreSales { get; set; } = [];
}