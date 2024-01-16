using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results;

public class GetRoleDetails
{
	[JsonPropertyName("roleId")]
	public string RoleId { get; set; }

	[JsonPropertyName("api")]
	public string Api { get; set; }

	[JsonPropertyName("httpVerb")]
	public string HttpVerb { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("lastChangedOn")]
	public string LastChangedOn { get; set; }

	[JsonPropertyName("lastChangedAt")]
	public string LastChangedAt { get; set; }
}