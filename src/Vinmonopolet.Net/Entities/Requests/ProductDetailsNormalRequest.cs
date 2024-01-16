using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class ProductDetailsNormalRequest
{
	/// <summary>
	/// Returns details of all products that match productId
	/// </summary>
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	/// <summary>
	/// Returns details of all products that match vendorId
	/// </summary>
	[JsonPropertyName("vendorId")]
	public int? VendorId { get; set; } = null;

	/// <summary>
	/// Returns details of all products that match manufacturerId
	/// </summary>
	[JsonPropertyName("manufacturerId")]
	public int? ManufacturerId { get; set; } = null;

	/// <summary>
	/// Returns details of all products that match wholesalerId
	/// </summary>
	[JsonPropertyName("wholesalerId")]
	public int? WholeSalerId { get; set; } = null;

	/// <summary>
	/// Returns details of all products that have been updated since the supplied date - only numeric yyyy-MM-dd
	/// </summary>
	[JsonPropertyName("changedSince")]
	public string ChangedSince { get; set; } = string.Empty;

	/// <summary>
	/// Returns details of all products where productShortName contains the supplied string
	/// </summary>
	[JsonPropertyName("productShortNameContains")]
	public string ProductShortNameContains { get; set; } = string.Empty;

	/// <summary>
	/// Limits the maximum number of products returned in each request
	/// </summary>
	[JsonPropertyName("maxResults")]
	public int? MaxResults { get; set; } = null;

	/// <summary>
	/// Skips the supplied amount of products, ordered by productID
	/// </summary>
	[JsonPropertyName("start")]
	public int? Start { get; set; } = null;
}