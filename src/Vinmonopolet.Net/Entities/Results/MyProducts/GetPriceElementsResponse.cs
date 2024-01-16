using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetPriceElementsResponse
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("priceElements")]
	public List<PriceElement> PriceElements { get; set; } = [];
}

public class PriceElement
{
    [JsonPropertyName("salesPrice")]
    public double? SalesPrice { get; set; } = null;

    [JsonPropertyName("markup")]
    public double? Markup { get; set; } = null;

    [JsonPropertyName("dduPrice")]
    public double? DduPrice { get; set; } = null;

    [JsonPropertyName("salesPricePrLiter")]
    public double? SalesPricePrLiter { get; set; } = null;

    [JsonPropertyName("valueAddedTax")]
    public double? ValueAddedTax { get; set; } = null;

    [JsonPropertyName("alcoholTax")]
    public double? AlcoholTax { get; set; } = null;

    [JsonPropertyName("ecoTax")]
    public double? EcoTax { get; set; } = null;

    [JsonPropertyName("packagingTax")]
    public double? PackagingTax { get; set; } = null;

    [JsonPropertyName("bottleReturnValue")]
    public double? BottleReturnValue { get; set; } = null;

    [JsonPropertyName("ddpPrice")]
    public double? DdpPrice { get; set; } = null;
}