using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Requests;

public class AddPermissionRequest
{
	[JsonPropertyName("email")] public string Email { get; set; }
	[JsonPropertyName("roleId")] public string RoleId { get; set; }
	[JsonPropertyName("mainRoleId")] public string MainRoleId { get; set; }
	[JsonPropertyName("active")] public bool Active { get; set; }
}