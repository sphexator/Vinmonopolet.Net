using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results;

public class ProductGetDetailsNormalResponse
{
    [JsonPropertyName("basic")]
    public Basic Basic { get; set; }

    [JsonPropertyName("lastChanged")]
    public LastChanged LastChanged { get; set; }
}

public class Basic
{
    [JsonPropertyName("productId")]
    public string ProductId { get; set; }

    [JsonPropertyName("productShortName")]
    public string ProductShortName { get; set; }
}

public class LastChanged
{
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; }
}