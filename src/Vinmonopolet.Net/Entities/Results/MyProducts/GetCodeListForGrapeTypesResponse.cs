using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForGrapeTypesResponse
{
	[JsonPropertyName("grapeId")]
	public string GrapeId { get; set; }

	[JsonPropertyName("grapeDesc")]
	public string GrapeDesc { get; set; }
}