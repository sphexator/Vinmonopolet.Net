using Microsoft.Extensions.Logging;
using Vinmonopolet.Entities.Interfaces;

namespace Vinmonopolet.Entities.Clients;

public sealed class VinmonopoletClient : IClient
{
	private readonly VinmonopoletOptions _options;
	private readonly HttpClient _httpClient;
	private readonly ILogger<VinmonopoletClient> _logger;
	
	public VinmonopoletClient(VinmonopoletOptions options, ILogger<VinmonopoletClient> logger, HttpClient httpClient)
	{
		_options = options;
		_logger = logger;
		_httpClient = httpClient;

		Auth = new Auth();
		MyProducts = new MyProducts();
		Products = new Products();
		Stores = new Stores();
	}

	public IAuthClient Auth { get; }
	public IMyProductsClient MyProducts { get; }
	public IProductsClient Products { get; }
	public IStoreClient Stores { get; }
}