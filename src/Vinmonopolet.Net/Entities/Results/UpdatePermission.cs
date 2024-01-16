using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results;

public sealed class UpdatePermission
{
	[JsonPropertyName("email")]
	public string Email { get; set; }

	[JsonPropertyName("accessToWholesaler")]
	public string AccessToWholesaler { get; set; }

	[JsonPropertyName("roleId")]
	public string RoleId { get; set; }

	[JsonPropertyName("mainRoleId")]
	public string MainRoleId { get; set; }

	[JsonPropertyName("active")]
	public bool Active { get; set; }

	[JsonPropertyName("lastChangedOn")]
	public string LastChangedOn { get; set; }

	[JsonPropertyName("lastChangedAt")]
	public string LastChangedAt { get; set; }

	[JsonPropertyName("result")]
	public string Result { get; set; }
}