using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetProductHierarchyResponse
{
	[JsonPropertyName("mainProductTypeId")]
	public string MainProductTypeId { get; set; } = string.Empty;

	[JsonPropertyName("mainProductTypeName")]
	public string MainProductTypeName { get; set; } = string.Empty;

	[JsonPropertyName("subProductTypes")]
	public List<SubProductType> SubProductTypes { get; set; } = [];
}

public class SubProductType
{
    [JsonPropertyName("subProductTypeId")]
    public string SubProductTypeId { get; set; } = string.Empty;

    [JsonPropertyName("subProductTypeName")]
    public string SubProductTypeName { get; set; } = string.Empty;

    [JsonPropertyName("productTypes")]
    public List<ProductType> ProductTypes { get; set; } = [];
}

public class ProductType
{
    [JsonPropertyName("productTypeId")]
    public string ProductTypeId { get; set; } = string.Empty;

    [JsonPropertyName("productTypeName")]
    public string ProductTypeName { get; set; } = string.Empty;
}