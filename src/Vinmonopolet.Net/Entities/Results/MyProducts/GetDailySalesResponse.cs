using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetDailySalesResponse
{
    /// <summary>
    /// Sales date in format: yyyy-MM-dd
    /// </summary>
    [JsonPropertyName("salesDate")]
    public string SalesDate { get; set; } = string.Empty;

    [JsonPropertyName("storeSales")]
    public List<StoreSale> StoreSales { get; set; } = [];
}

public class StoreSale
{
    /// <summary>
    /// Store ID
    /// </summary>
    [JsonPropertyName("storeId")]
    public string StoreId { get; set; } = string.Empty;

    [JsonPropertyName("sales")]
    public List<Sale> Sales { get; set; } = [];
}

public class Sale
{
    /// <summary>
    /// Product ID
    /// </summary>
    [JsonPropertyName("productId")]
    public string ProductId { get; set; } = string.Empty;

    /// <summary>
    /// Sales volume in liters, with three decimals
    /// </summary>
    [JsonPropertyName("salesVolume")]
    public double? SalesVolume { get; set; } = null;

    /// <summary>
    /// Sales volume in number of items
    /// </summary>
    [JsonPropertyName("salesQuantity")]
    public double? SalesQuantity { get; set; } = null;

    [JsonPropertyName("lastChanged")]
    public LastChanged LastChanged { get; set; } = new();
}

public class LastChanged
{
    /// <summary>
    /// Date when product sales last changed
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    /// <summary>
    /// Time when product sales last changed
    /// </summary>
    [JsonPropertyName("time")]
    public string Time { get; set; } = string.Empty;
}