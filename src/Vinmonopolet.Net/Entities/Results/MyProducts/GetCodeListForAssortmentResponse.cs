using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForAssortmentResponse
{
	[JsonPropertyName("assortmentId")]
	public string AssortmentId { get; set; }

	[JsonPropertyName("assortment")]
	public string Assortment { get; set; }
}