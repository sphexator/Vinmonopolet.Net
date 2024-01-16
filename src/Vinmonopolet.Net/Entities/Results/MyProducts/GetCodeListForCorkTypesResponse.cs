using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForCorkTypesResponse
{
	[JsonPropertyName("corkTypeId")]
	public string CorkTypeId { get; set; }

	[JsonPropertyName("corkType")]
	public string CorkType { get; set; }
}