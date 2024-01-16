using System.Text.Json.Serialization;
using Vinmonopolet.Entities.Results;

namespace Vinmonopolet.Entities.Interfaces;

public interface IStoreClient
{
    public Task<GetStoreDetailsResponse> GetStoreDetailsAsync(Action<StoreDetailsRequest> param,
            CancellationToken cancellationToken = default);
}

public class StoreDetailsRequest
{
    /// <summary>
    /// Returns details of the Store with the given number
    /// </summary>
    [JsonPropertyName("storeId")]
    public int? StoreId { get; set; } = null;

    /// <summary>
    /// Returns details of Stores whose name contains the provided string
    /// </summary>
    [JsonPropertyName("storeNameContains")]
    public string StoreNameContains { get; set; } = string.Empty;

    /// <summary>
    /// Returns details of Stores which have been updated since the supplied date (yyyy-MM-dd)
    /// </summary>
    [JsonPropertyName("changedSince")]
    public string ChangedSince { get; set; } = string.Empty;
}

public class RegularHours
{
    [JsonPropertyName("dayOfTheWeek")]
    public string DayOfTheWeek { get; set; } = string.Empty;

    [JsonPropertyName("openingTime")]
    public string OpeningTime { get; set; } = string.Empty;

    [JsonPropertyName("closingTime")]
    public string ClosingTime { get; set; } = string.Empty;

    [JsonPropertyName("closed")]
    public bool? Closed { get; set; } = null;
}

public class ExceptionHours
{
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    [JsonPropertyName("openingTime")]
    public string OpeningTime { get; set; } = string.Empty;

    [JsonPropertyName("closingTime")]
    public string ClosingTime { get; set; } = string.Empty;

    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}

public class OpeningHours
{
    [JsonPropertyName("regularHours")]
    public List<RegularHours> RegularHours { get; set; } = [];

    [JsonPropertyName("exceptionHours")]
    public List<ExceptionHours> ExceptionHours { get; set; } = [];
}

public class Address
{
    [JsonPropertyName("street")]
    public string Street { get; set; } = string.Empty;

    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; } = string.Empty;

    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;

    [JsonPropertyName("gpsCoord")]
    public string GpsCoord { get; set; } = string.Empty;

    [JsonPropertyName("globalLocationNumber")]
    public string GlobalLocationNumber { get; set; } = string.Empty;

    [JsonPropertyName("organisationNumber")]
    public string OrganisationNumber { get; set; } = string.Empty;
}

public class GetStoreDetailsResponse
{
    [JsonPropertyName("storeId")]
    public string StoreId { get; set; } = string.Empty;

    [JsonPropertyName("storeName")]
    public string StoreName { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("address")]
    public Address Address { get; set; } = new Address();

    [JsonPropertyName("telephone")]
    public string Telephone { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("profile")]
    public string Profile { get; set; } = string.Empty;

    [JsonPropertyName("storeAssortment")]
    public string StoreAssortment { get; set; } = string.Empty;

    [JsonPropertyName("openingHours")]
    public OpeningHours OpeningHours { get; set; } = new();

    [JsonPropertyName("lastChanged")]
    public LastChanged LastChanged { get; set; } = new();
}