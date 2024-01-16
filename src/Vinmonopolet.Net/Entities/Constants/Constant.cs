namespace Vinmonopolet.Entities.Constants;

internal static class Constant
{
	public const string BaseUri = "https://apis.vinmonopolet.no/";
	private const string V0 = "v0/";
	private const string V1 = "v1/";

	internal static class AuthUri
	{
		private const string ABaseUri = "auth/" + V0;
		public const string PutPermission = ABaseUri + "permission";
		public const string DelPermission = ABaseUri + "permission";
		public const string DelUser = ABaseUri + "user";
		public const string GetMainRole = ABaseUri + "main_role";
		public const string GetRoleDetails = ABaseUri + "role";
		public const string GetPermission = ABaseUri + "permission";
		public const string PostPermission = ABaseUri + "permission";
	}
	
	internal static class MyProductUri
	{
		private const string ABaseUri = "my-products/" + V1;
		public const string GetAssortmentGrades = ABaseUri + "assortmentgrades";
		public const string GetAssortmentList = ABaseUri + "assortmentlist";
		public const string GetCork = ABaseUri + "cork";
		public const string GetEcoLabel = ABaseUri + "ecolabel";
		public const string GetGrapes = ABaseUri + "grapes";
		public const string GetOrderPack = ABaseUri + "orderpack";
		public const string GetPackage = ABaseUri + "package";
		public const string GetProductGroups = ABaseUri + "prodgrp";
		public const string GetRecommendedFoods = ABaseUri + "use";
		public const string GetRegions = ABaseUri + "regions";
		public const string GetStatus = ABaseUri + "status";
		public const string GetStorage = ABaseUri + "storage";
		public const string GetVolume = ABaseUri + "volume";
		public const string GetDailySalesPerStore = ABaseUri + "daily-sales-per-store";
		public const string GetDetails = ABaseUri + "details";
		public const string GetDetailsNormal = ABaseUri + "details-normal";
		public const string GetDetailsSpecial = ABaseUri + "details-special";
		public const string GetOnlineStock = ABaseUri + "online-stock";
		public const string GetPriceElements = ABaseUri + "price-elements";
		public const string GetPriceElementsNormal = ABaseUri + "price-elements-normal";
		public const string GetPriceElementsSpecial = ABaseUri + "price-elements-special";
		public const string GetHierarchy = ABaseUri + "hierarchy";
		public const string GetStockPerStore = ABaseUri + "stock-per-store";
		public const string GetUpdateErrorCodeList = ABaseUri + "update_error_codelist";
		public const string PutUpdates = ABaseUri + "updates";
		public const string PutVendorStock = ABaseUri + "vendor-stock";
	}
	
	internal static class ProductsUri
	{
		private const string ABaseUri = "products/" + V0;
		public const string DetailsNormal = ABaseUri + "details-normal";
		public const string MonthlySales = ABaseUri + "monthly-sales-per-store";
	}
	
	internal static class StoresUri
	{
		private const string ABaseUri = "stores/" + V0;
		public const string Details = ABaseUri + "details";
	}
}