using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results;

namespace Vinmonopolet.Entities.Interfaces;

public interface IProductsClient
{
	/// <summary>
	/// Master data is updated approx 05:45 AM CET every day.
	/// Use parameter "changedSince" to get only updated products, including products that have been removed from basic, one lot, test and ordering ranges since supplied date.
	/// Throttling as per 15. November 2019: Max 60 calls per minute. Max 4000 calls per day.
	/// </summary>
	/// <param name="param"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public Task<ProductDetailsNormalRequest> GetDetailsNormalAsync(Action<ProductDetailsNormalRequest> param,
			CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns monthly sales data.
	/// Monthly sales available from the 35th day after a month, at approx 07:30 AM CET.
	/// Use parameter "changedSince" to get any updates / corrections made to historic sales.
	/// Select only one month to avoid pagination.
	/// If you experience timeouts, use pagination by sending parameter maxResults (default 1048575 ).
	/// Throttling as per 19. August 2021: Max 6 calls per minute. Max 60 calls per day.
	/// </summary>
	/// <param name="param"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public Task<ProductGetMonthlySalesResponse> GetMonthlySalesAsync(Action<ProductMonthlySalesRequest> param,
			CancellationToken cancellationToken = default);
}