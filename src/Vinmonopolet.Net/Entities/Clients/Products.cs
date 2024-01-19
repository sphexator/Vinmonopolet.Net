using Microsoft.Extensions.Logging;
using Vinmonopolet.Entities.Constants;
using Vinmonopolet.Entities.Interfaces;
using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results;

namespace Vinmonopolet.Entities.Clients;

public sealed class Products : IProductsClient
{
	private readonly HttpClient _httpClient;
	private readonly ILogger<Products> _logger;
	public Products(IHttpClientFactory httpClientFactory, ILogger<Products> logger)
	{
		_httpClient = httpClientFactory.CreateClient(Constant.HttpClientName);
		_logger = logger;
	}
	
	/// <inheritdoc />
	public async Task<ProductDetailsNormalRequest> GetDetailsNormalAsync(Action<ProductDetailsNormalRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<ProductGetMonthlySalesResponse> GetMonthlySalesAsync(Action<ProductMonthlySalesRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}