using System.Text.Json.Serialization;
using Vinmonopolet.Entities.Results.MyProducts;

namespace Vinmonopolet.Entities.Requests;

public class UpdateProductBarcodesVintageYearStatusStockRequest
{
	[JsonPropertyName("productId")]
	public string ProductId { get; set; } = string.Empty;

	[JsonPropertyName("vintage")]
	public string Vintage { get; set; } = string.Empty;

	[JsonPropertyName("productStatusSaleId")]
	public string ProductStatusSaleId { get; set; } = string.Empty;

	[JsonPropertyName("barcodes")]
	public List<Barcode> Barcodes { get; set; } = new List<Barcode>();

	[JsonPropertyName("stock")]
	public Stock Stock { get; set; } = new Stock();
}