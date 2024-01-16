using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForStorageResponse
{
	[JsonPropertyName("storagePotentialId")]
	public string StoragePotentialId { get; set; } = string.Empty;

	[JsonPropertyName("storagePotential")]
	public string StoragePotential { get; set; } = string.Empty;
}