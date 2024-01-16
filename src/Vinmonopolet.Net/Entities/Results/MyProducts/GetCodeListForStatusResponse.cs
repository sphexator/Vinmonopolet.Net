using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForStatusResponse
{
	/// <summary>
	/// Specifies the current sales status code.
	/// </summary>
	[JsonPropertyName("productStatusSaleId")]
	public string ProductStatusSaleId { get; set; } = string.Empty;

	/// <summary>
	/// Current sales status code description
	/// </summary>
	[JsonPropertyName("productStatusSaleName")]
	public string ProductStatusSaleName { get; set; } = string.Empty;
}