using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForEcoLabelsResponse
{
	/// <summary>
	/// Total number of records that satisfy the request criteria
	/// </summary>
	[JsonPropertyName("x-total-count")]
	public int? TotalCount { get; set; }

	/// <summary>
	/// Links to previous/next pages
	/// </summary>
	[JsonPropertyName("link")]
	public string Link { get; set; }
}