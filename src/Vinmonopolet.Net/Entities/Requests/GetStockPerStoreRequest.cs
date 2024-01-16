using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class GetStockPerStoreRequest
{
	/// <summary>
	/// Returns stock of products that match productId
	/// </summary>
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	/// <summary>
	/// Returns stock of products in the specified storeId
	/// </summary>
	[JsonPropertyName("storeId")]
	public int? StoreId { get; set; } = null;

	/// <summary>
	/// Returns stock of products that match vendorId
	/// </summary>
	[JsonPropertyName("vendorId")]
	public int? VendorId { get; set; } = null;

	/// <summary>
	/// Returns stock of products that match manufacturerId
	/// </summary>
	[JsonPropertyName("manufacturerId")]
	public int? ManufacturerId { get; set; } = null;

	/// <summary>
	/// Returns stock of products that match wholesalerId
	/// </summary>
	[JsonPropertyName("wholesalerId")]
	public int? WholesalerId { get; set; } = null;

	/// <summary>
	/// Returns stock of products that have been updated since the supplied date (yyyy-MM-dd)
	/// </summary>
	[JsonPropertyName("changedSince")]
	public string ChangedSince { get; set; } = string.Empty;

	/// <summary>
	/// Returns stock of products where productShortName contains the supplied string
	/// </summary>
	[JsonPropertyName("productShortNameContains")]
	public string ProductShortNameContains { get; set; } = string.Empty;

	/// <summary>
	/// Include products which are sold and its stock is 0 (zero)
	/// </summary>
	[JsonPropertyName("includeZeroStock")]
	public bool IncludeZeroStock { get; set; } = false;
}