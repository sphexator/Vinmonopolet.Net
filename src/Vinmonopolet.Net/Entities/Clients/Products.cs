using Vinmonopolet.Entities.Interfaces;
using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results;

namespace Vinmonopolet.Entities.Clients;

public sealed class Products : IProductsClient
{
	/// <inheritdoc />
	public async Task<ProductDetailsNormalRequest> GetDetailsNormalAsync(Action<ProductDetailsNormalRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	/// <inheritdoc />
	public async Task<ProductGetMonthlySalesResponse> GetMonthlySalesAsync(Action<ProductMonthlySalesRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}