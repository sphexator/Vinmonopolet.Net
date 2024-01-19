using Microsoft.Extensions.Logging;
using Vinmonopolet.Entities.Constants;
using Vinmonopolet.Entities.Interfaces;

namespace Vinmonopolet.Entities.Clients;

public sealed class Stores : IStoreClient
{
	private readonly HttpClient _httpClient;
	private readonly ILogger<Stores> _logger;
	public Stores(IHttpClientFactory httpClientFactory, ILogger<Stores> logger)
	{
		_httpClient = httpClientFactory.CreateClient(Constant.HttpClientName);
		_logger = logger;
	}
	
	public async Task<GetStoreDetailsResponse> GetStoreDetailsAsync(Action<StoreDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}