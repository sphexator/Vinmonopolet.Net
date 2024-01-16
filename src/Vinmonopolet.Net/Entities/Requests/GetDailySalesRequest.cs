using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class GetDailySalesRequest
{ 
    /// <summary>
    /// Returns sales occurrences in interval from this sales date
    /// </summary>
    [JsonPropertyName("fromSalesDate")]
    public string FromSalesDate { get; set; } = string.Empty;

    /// <summary>
    /// Returns sales occurrences in interval to this sales date
    /// </summary>
    [JsonPropertyName("toSalesDate")]
    public string ToSalesDate { get; set; } = string.Empty;

    /// <summary>
    /// Returns sales occurrences in interval from this store id number
    /// </summary>
    [JsonPropertyName("fromStoreId")]
    public int? FromStoreId { get; set; } = null;

    /// <summary>
    /// Returns sales occurrences in interval to this store id number
    /// </summary>
    [JsonPropertyName("toStoreId")]
    public int? ToStoreId { get; set; } = null;

    /// <summary>
    /// Returns sales occurrences for requested productId
    /// </summary>
    [JsonPropertyName("productId")]
    public string ProductId { get; set; } = string.Empty;

    /// <summary>
    /// Returns sales occurrences for requested vendorId
    /// </summary>
    [JsonPropertyName("vendorId")]
    public int? VendorId { get; set; } = null;

    /// <summary>
    /// Returns sales occurrences for requested wholesalerId
    /// </summary>
    [JsonPropertyName("wholesalerId")]
    public int? WholesalerId { get; set; } = null;

    /// <summary>
    /// Returns sales occurrences that have been updated since the supplied date - only numeric yyyy-MM-dd
    /// </summary>
    [JsonPropertyName("changedSince")]
    public string ChangedSince { get; set; } = string.Empty;

    /// <summary>
    /// Limits the maximum number of sales occurrences returned in each request
    /// </summary>
    [JsonPropertyName("maxResults")]
    public int? MaxResults { get; set; } = null;

    /// <summary>
    /// Skips the supplied amount of sales occurrences, ordered by sales date, store and productId
    /// </summary>
    [JsonPropertyName("start")]
    public int? Start { get; set; } = null;
}