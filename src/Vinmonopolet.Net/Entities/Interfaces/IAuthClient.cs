using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results;

namespace Vinmonopolet.Entities.Interfaces;

public interface IAuthClient
{
	public Task<UpdatePermission> UpdatePermissionByEmailAsync(string email, bool active, CancellationToken cancellationToken = default);
	public Task<UpdatePermission> UpdatePermissionByRoleIdAsync(string roleId, bool active, CancellationToken cancellationToken = default);
	public Task<UpdatePermission> UpdatePermissionByMainRoleIdAsync(string mainRoleId, bool active, CancellationToken cancellationToken = default);
	public Task<UpdatePermission> UpdatePermissionAsync(string email, string roleId, string mainRoleId, bool active,
			CancellationToken cancellationToken = default);
	
	public Task<bool> DeletePermissionByEmailAsync(string email, CancellationToken cancellationToken = default);
	public Task<bool> DeletePermissionByRoleIdAsync(string roleId, CancellationToken cancellationToken = default);
	
	public Task<GetMainRoles> GetMainRolesAsync(CancellationToken cancellationToken = default);
	public Task<GetRoleDetails> GetRoleDetailsAsync(string roleId, CancellationToken cancellationToken = default);
	public Task<GetWhoAccess> GetWhoAccessAsync(CancellationToken cancellationToken = default);
	
	public Task<AddPermission> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default);
}