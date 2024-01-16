using Vinmonopolet.Entities.Requests;
using Vinmonopolet.Entities.Results.MyProducts;

namespace Vinmonopolet.Entities.Interfaces;

public interface IMyProductsClient
{
    Task<GetCodeListForAssortmentGradeResponse> GetCodeListForAssortmentGradeAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForAssortmentResponse> GetCodeListForAssortmentsAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForCorkTypesResponse> GetCodeListForCorkTypesAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForEcoLabelsResponse> GetCodeListForEcoLabelsAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForGrapeTypesResponse> GetCodeListForGrapeTypesAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForOrderPacksResponse> GetCodeListForOrderPacksAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForPackageUnitsResponse> GetCodeListForPackageUnitsAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForProductGroupsResponse> GetCodeListForProductGroupsAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForRecommendedFoodResponse> GetCodeListForRecommendedFoodAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForRegionsResponse> GetCodeListForRegionsAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForStatusResponse> GetCodeListForStatusAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForStorageResponse> GetCodeListForStorageAsync(CancellationToken cancellationToken = default);
    Task<GetCodeListForUnitsOfVolumeResponse> GetCodeListForUnitsOfVolumeAsync(CancellationToken cancellationToken = default);
    Task<GetDailySalesResponse> GetDailySalesAsync(Action<GetDailySalesRequest> param, CancellationToken cancellationToken = default);
    Task<GetDetailsResponse> GetDetailsForAllRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default);
    Task<GetDetailsResponse> GetDetailsNormalAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default);
    Task<GetDetailsResponse> GetDetailsSpecialAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default);
    Task<GetOnlineStockResponse> GetOnlineStockAsync(GetOnlineStockRequest request, CancellationToken cancellationToken = default);
    Task<GetPriceElementsResponse> GetPriceElementsForAllRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default);
    Task<GetPriceElementsResponse> GetPriceElementsForNormalRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default);
    Task<GetPriceElementsResponse> GetPriceElementsForSpecialRangesAsync(Action<GetDetailsRequest> param, CancellationToken cancellationToken = default);
    Task<GetProductHierarchyResponse> GetProductHierarchyAsync(CancellationToken cancellationToken = default);
    Task<GetStockPerStoreResponse> GetStockPerStoreAsync(Action<GetStockPerStoreRequest> param, CancellationToken cancellationToken = default);
    Task<ReturnsAllDefinedErrorCodesForUpdateOperationResponse> ReturnsAllDefinedErrorCodesForUpdateOperationAsync(CancellationToken cancellationToken = default);
    
    Task<UpdateProductBarcodesVintageYearStatusStockResponse> UpdateProductBarcodesVintageYearStatusStockAsync(Action<UpdateProductBarcodesVintageYearStatusStockRequest> param, CancellationToken cancellationToken = default);
    Task<UpdateVendorStockAvailableResponse> UpdateVendorStockAvailableAsync(Action<UpdateVendorStockAvailableRequest> param, CancellationToken cancellationToken = default);
}