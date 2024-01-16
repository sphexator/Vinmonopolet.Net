using Vinmonopolet.Entities.Interfaces;
using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results.MyProducts;

namespace Vinmonopolet.Entities.Clients;

public sealed class MyProducts : IMyProductsClient
{
	public async Task<GetCodeListForAssortmentGradeResponse> GetCodeListForAssortmentGradeAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForAssortmentResponse> GetCodeListForAssortmentsAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForCorkTypesResponse> GetCodeListForCorkTypesAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForEcoLabelsResponse> GetCodeListForEcoLabelsAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForGrapeTypesResponse> GetCodeListForGrapeTypesAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForOrderPacksResponse> GetCodeListForOrderPacksAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForPackageUnitsResponse> GetCodeListForPackageUnitsAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForProductGroupsResponse> GetCodeListForProductGroupsAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForRecommendedFoodResponse> GetCodeListForRecommendedFoodAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForRegionsResponse> GetCodeListForRegionsAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForStatusResponse> GetCodeListForStatusAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForStorageResponse> GetCodeListForStorageAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetCodeListForUnitsOfVolumeResponse> GetCodeListForUnitsOfVolumeAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetDailySalesResponse> GetDailySalesAsync(Action<GetDailySalesRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetDetailsResponse> GetDetailsForAllRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetDetailsResponse> GetDetailsNormalAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetDetailsResponse> GetDetailsSpecialAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetOnlineStockResponse> GetOnlineStockAsync(GetOnlineStockRequest request, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetPriceElementsResponse> GetPriceElementsForAllRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetPriceElementsResponse> GetPriceElementsForNormalRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetPriceElementsResponse> GetPriceElementsForSpecialRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetProductHierarchyResponse> GetProductHierarchyAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<GetStockPerStoreResponse> GetStockPerStoreAsync(Action<GetStockPerStoreRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<ReturnsAllDefinedErrorCodesForUpdateOperationResponse> ReturnsAllDefinedErrorCodesForUpdateOperationAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<UpdateProductBarcodesVintageYearStatusStockResponse> UpdateProductBarcodesVintageYearStatusStockAsync(Action<UpdateProductBarcodesVintageYearStatusStockRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public async Task<UpdateVendorStockAvailableResponse> UpdateVendorStockAvailableAsync(Action<UpdateVendorStockAvailableRequest> param, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}