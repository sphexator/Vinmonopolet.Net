using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForRegionsResponse
{
	[JsonPropertyName("countryId")]
	public string CountryId { get; set; } = string.Empty;

	[JsonPropertyName("country")]
	public string Country { get; set; } = string.Empty;

	[JsonPropertyName("regions")]
	public List<Regions> Regions { get; set; } = [];
}

public class Regions
{
	[JsonPropertyName("regionId")]
	public string RegionId { get; set; } = string.Empty;

	[JsonPropertyName("region")]
	public string Region { get; set; } = string.Empty;

	[JsonPropertyName("subRegions")]
	public List<SubRegions> SubRegions { get; set; } = [];
}

public class SubRegions
{
    [JsonPropertyName("subRegionId")]
    public string SubRegionId { get; set; } = string.Empty;

    [JsonPropertyName("subRegion")]
    public string SubRegion { get; set; } = string.Empty;
}