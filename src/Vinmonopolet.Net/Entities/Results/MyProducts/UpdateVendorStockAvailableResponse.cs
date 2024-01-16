using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class UpdateVendorStockAvailableResponse
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("messages")]
	public List<Message> Messages { get; set; } = new List<Message>();

	[JsonPropertyName("changes")]
	public List<Change> Changes { get; set; } = new List<Change>();

	[JsonPropertyName("unchanged")]
	public List<Unchanged> Unchanged { get; set; } = new List<Unchanged>();
}

public class Message
{
    [JsonPropertyName("messNr")]
    public string MessNr { get; set; } = string.Empty;

    [JsonPropertyName("messText")]
    public string MessText { get; set; } = string.Empty;
}