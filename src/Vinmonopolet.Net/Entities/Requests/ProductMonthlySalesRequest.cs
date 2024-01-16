﻿using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class ProductMonthlySalesRequest
{
    /// <summary>
    /// Returns sales occurrences in interval from this sales month yyyy-MM
    /// </summary>
    [JsonPropertyName("fromSalesMonth")]
    public string FromSalesMonth { get; set; } = string.Empty;

    /// <summary>
    /// Returns sales occurrences in interval to this sales month yyyy-MM
    /// </summary>
    [JsonPropertyName("toSalesMonth")]
    public string ToSalesMonth { get; set; } = string.Empty;

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
    public int? ProductId { get; set; } = null;

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
    /// Returns sales occurrences that have been updated since the supplied month - only yyyy-MM-dd
    /// </summary>
    [JsonPropertyName("changedSince")]
    public string ChangedSince { get; set; } = string.Empty;

    /// <summary>
    /// Limits the maximum number of sales occurrences returned in each request
    /// </summary>
    [JsonPropertyName("maxResults")]
    public int? MaxResults { get; set; } = null;

    /// <summary>
    /// Skips the supplied amount of sales occurrences, ordered by sales month, store and productId
    /// </summary>
    [JsonPropertyName("start")]
    public int? Start { get; set; } = null;
}