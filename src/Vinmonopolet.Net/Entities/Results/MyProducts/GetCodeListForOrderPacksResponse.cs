using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForOrderPacksResponse
{
	/// <summary>
	/// Unit of measure that is used to determine size of purchase order package (in consumer sales units)
	/// </summary>
	[JsonPropertyName("orderPack")]
	public string OrderPack { get; set; }

	/// <summary>
	/// Unit of measure description
	/// </summary>
	[JsonPropertyName("orderPackDesc")]
	public string OrderPackDesc { get; set; }

	/// <summary>
	/// Quantity in consumer sales units
	/// </summary>
	[JsonPropertyName("packageQuantity")]
	public double? PackageQuantity { get; set; }
}