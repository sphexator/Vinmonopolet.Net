using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForUnitsOfVolumeResponse
{
	[JsonPropertyName("volumTypeId")]
	public string VolumeTypeId { get; set; } = string.Empty;

	[JsonPropertyName("volumType")]
	public string VolumeType { get; set; } = string.Empty;
}