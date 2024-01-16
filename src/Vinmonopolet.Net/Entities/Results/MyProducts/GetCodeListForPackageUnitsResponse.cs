using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForPackageUnitsResponse
{
	[JsonPropertyName("packagingMaterialId")]
	public string PackagingMaterialId { get; set; }

	[JsonPropertyName("packagingMaterial")]
	public string PackagingMaterial { get; set; }
}