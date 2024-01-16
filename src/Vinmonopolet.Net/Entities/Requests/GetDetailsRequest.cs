using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class GetDetailsRequest
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("vendorId")]
	public int? VendorId { get; set; } = null;

	[JsonPropertyName("manufacturerId")]
	public int? ManufacturerId { get; set; } = null;

	[JsonPropertyName("wholesalerId")]
	public int? WholesalerId { get; set; } = null;

	[JsonPropertyName("changedSince")]
	public string ChangedSince { get; set; } = string.Empty;

	[JsonPropertyName("productShortNameContains")]
	public string ProductShortNameContains { get; set; } = string.Empty;

	[JsonPropertyName("maxResults")]
	public int? MaxResults { get; set; } = null;

	[JsonPropertyName("start")]
	public int? Start { get; set; } = null;

	[JsonPropertyName("freeText")]
	public string FreeText { get; set; } = string.Empty;

	[JsonPropertyName("changedSinceTimestamp")]
	public string ChangedSinceTimestamp { get; set; } = string.Empty;
}