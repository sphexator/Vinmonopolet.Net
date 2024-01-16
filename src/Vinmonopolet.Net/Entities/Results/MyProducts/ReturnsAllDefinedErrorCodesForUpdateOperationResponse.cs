using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class ReturnsAllDefinedErrorCodesForUpdateOperationResponse
{
    [JsonPropertyName("norwegians")]
	public List<Norwegian> Norwegians { get; set; } = [];
    [JsonPropertyName("englishes")]
    public List<English> Englishes { get; set; } = [];
}

public class Norwegian
{
    [JsonPropertyName("error")]
    public string Error { get; set; } = string.Empty;

    [JsonPropertyName("errorText")]
    public string ErrorText { get; set; } = string.Empty;
}

public class English
{
    [JsonPropertyName("error")]
    public string Error { get; set; } = string.Empty;

    [JsonPropertyName("errorText")]
    public string ErrorText { get; set; } = string.Empty;
}