using Vinmonopolet.Entities.Interfaces;
using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results;

namespace Vinmonopolet.Entities.Clients;

public sealed class Auth : IAuthClient
{
	/// <inheritdoc />
	public async Task<UpdatePermission> UpdatePermissionByEmailAsync(string email, bool active, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<UpdatePermission> UpdatePermissionByRoleIdAsync(string roleId, bool active, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<UpdatePermission> UpdatePermissionByMainRoleIdAsync(string mainRoleId, bool active, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<UpdatePermission> UpdatePermissionAsync(string email, string roleId, string mainRoleId, bool active,
			CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<bool> DeletePermissionByEmailAsync(string email, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<bool> DeletePermissionByRoleIdAsync(string roleId, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<GetMainRoles> GetMainRolesAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<GetRoleDetails> GetRoleDetailsAsync(string roleId, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<GetWhoAccess> GetWhoAccessAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<AddPermission> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}