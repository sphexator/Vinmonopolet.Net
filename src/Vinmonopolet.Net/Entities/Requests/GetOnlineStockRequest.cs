using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class GetOnlineStockRequest
{
	/// <summary>
	/// Returns realtime stock for product that match productId
	/// </summary>
	[JsonPropertyName("productId")]
	public string ProductId { get; set; }

	/// <summary>
	/// Returns realtime stock in store that match storeId
	/// </summary>
	[JsonPropertyName("storeId")]
	public int StoreId { get; set; }
}