using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class UpdateVendorStockAvailableRequest
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("quantity")]
	public string Quantity { get; set; } = string.Empty;

	[JsonPropertyName("utcTimestamp")]
	public string UtcTimestamp { get; set; } = string.Empty;

}