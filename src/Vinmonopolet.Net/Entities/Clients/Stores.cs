using Vinmonopolet.Entities.Interfaces;

namespace Vinmonopolet.Entities.Clients;

public sealed class Stores : IStoreClient
{
	public async Task<GetStoreDetailsResponse> GetStoreDetailsAsync(Action<StoreDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}