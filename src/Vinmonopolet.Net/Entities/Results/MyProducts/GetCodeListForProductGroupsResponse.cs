using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForProductGroupsResponse
{
	[JsonPropertyName("productGroupId")]
	public string ProductGroupId { get; set; } = string.Empty;

	[JsonPropertyName("productGroupName")]
	public string ProductGroupName { get; set; } = string.Empty;
}