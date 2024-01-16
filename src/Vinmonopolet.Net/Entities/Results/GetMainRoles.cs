using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results;

public sealed class GetMainRoles
{
    [JsonPropertyName("mainRoleId")]
    public string MainRoleId { get; set; }

    [JsonPropertyName("roleId")]
    public string RoleId { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("lastChangedOn")]
    public string LastChangedOn { get; set; }

    [JsonPropertyName("lastChangedAt")]
    public string LastChangedAt { get; set; }
}