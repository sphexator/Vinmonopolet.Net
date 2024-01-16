using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class UpdateProductBarcodesVintageYearStatusStockResponse
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("errors")]
	public List<Error> Errors { get; set; } = [];

	[JsonPropertyName("changes")]
	public List<Change> Changes { get; set; } = [];

	[JsonPropertyName("unchanged")]
	public List<Unchanged> Unchanged { get; set; } = [];
}

public class Error
{
    [JsonPropertyName("error")]
    public string ErrorCode { get; set; } = string.Empty;

    [JsonPropertyName("errorText")]
    public string ErrorText { get; set; } = string.Empty;
}

public class Change
{
    [JsonPropertyName("object")]
    public string Object { get; set; } = string.Empty;

    [JsonPropertyName("valueOld")]
    public string ValueOld { get; set; } = string.Empty;

    [JsonPropertyName("valueNew")]
    public string ValueNew { get; set; } = string.Empty;

    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
}

public class Unchanged
{
    [JsonPropertyName("object")]
    public string Object { get; set; } = string.Empty;

    [JsonPropertyName("valueOld")]
    public string ValueOld { get; set; } = string.Empty;

    [JsonPropertyName("valueNew")]
    public string ValueNew { get; set; } = string.Empty;

    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
}