using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetDetailsResponse
{
	[JsonPropertyName("basic")]
	public Basic Basic { get; set; } = new();

	[JsonPropertyName("logistics")]
	public Logistics Logistics { get; set; } = new();

	[JsonPropertyName("origins")]
	public Origins Origins { get; set; } = new();

	[JsonPropertyName("properties")]
	public Properties Properties { get; set; } = new();

	[JsonPropertyName("classification")]
	public Classification Classification { get; set; } = new();

	[JsonPropertyName("ingredients")]
	public Ingredient Ingredients { get; set; } = new();

	[JsonPropertyName("description")]
	public Description Description { get; set; } = new();

	[JsonPropertyName("assortment")]
	public Assortments Assortment { get; set; } = new();

	[JsonPropertyName("prices")]
	public List<Price> Prices { get; set; } = [];

	[JsonPropertyName("attributes")]
	public List<Attribute> Attributes { get; set; } = [];

	[JsonPropertyName("lastChanged")]
	public LastChanged LastChanged { get; set; } = new();
}

public class Basic
{
    [JsonPropertyName("productId")]
    public string ProductId { get; set; } = string.Empty;

    [JsonPropertyName("productShortName")]
    public string ProductShortName { get; set; } = string.Empty;

    [JsonPropertyName("productLongName")]
    public string ProductLongName { get; set; } = string.Empty;

    [JsonPropertyName("volume")]
    public double? Volume { get; set; } = null;

    [JsonPropertyName("alcoholContent")]
    public double? AlcoholContent { get; set; } = null;

    [JsonPropertyName("vintage")]
    public string Vintage { get; set; } = string.Empty;

    [JsonPropertyName("ageLimit")]
    public string AgeLimit { get; set; } = string.Empty;

    [JsonPropertyName("packagingMaterialId")]
    public string PackagingMaterialId { get; set; } = string.Empty;

    [JsonPropertyName("packagingMaterial")]
    public string PackagingMaterial { get; set; } = string.Empty;

    [JsonPropertyName("volumTypeId")]
    public string VolumTypeId { get; set; } = string.Empty;

    [JsonPropertyName("volumType")]
    public string VolumType { get; set; } = string.Empty;

    [JsonPropertyName("corkTypeId")]
    public string CorkTypeId { get; set; } = string.Empty;

    [JsonPropertyName("corkType")]
    public string CorkType { get; set; } = string.Empty;

    [JsonPropertyName("bottlePerSalesUnit")]
    public string BottlePerSalesUnit { get; set; } = string.Empty;

    [JsonPropertyName("introductionDate")]
    public string IntroductionDate { get; set; } = string.Empty;

    [JsonPropertyName("productStatusSaleId")]
    public string ProductStatusSaleId { get; set; } = string.Empty;

    [JsonPropertyName("productStatusSaleName")]
    public string ProductStatusSaleName { get; set; } = string.Empty;

    [JsonPropertyName("productStatusSaleValidFrom")]
    public string ProductStatusSaleValidFrom { get; set; } = string.Empty;
}

public class Production
{
    [JsonPropertyName("countryId")]
    public string CountryId { get; set; } = string.Empty;

    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    [JsonPropertyName("regionId")]
    public string RegionId { get; set; } = string.Empty;

    [JsonPropertyName("region")]
    public string Region { get; set; } = string.Empty;
}

public class Origin
{
    [JsonPropertyName("countryId")]
    public string CountryId { get; set; } = string.Empty;

    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    [JsonPropertyName("regionId")]
    public string RegionId { get; set; } = string.Empty;

    [JsonPropertyName("region")]
    public string Region { get; set; } = string.Empty;

    [JsonPropertyName("subRegionId")]
    public string SubRegionId { get; set; } = string.Empty;

    [JsonPropertyName("subRegion")]
    public string SubRegion { get; set; } = string.Empty;
}

public class Origins
{
    [JsonPropertyName("origin")]
    public Origin Origin { get; set; } = new();

    [JsonPropertyName("production")]
    public Production Production { get; set; } = new();

    [JsonPropertyName("localQualityClassifId")]
    public string LocalQualityClassifId { get; set; } = string.Empty;

    [JsonPropertyName("localQualityClassif")]
    public string LocalQualityClassif { get; set; } = string.Empty;
}

public class Barcode
{
    [JsonPropertyName("gtin")]
    public string Gtin { get; set; } = string.Empty;

    [JsonPropertyName("isMainGtin")]
    public bool IsMainGtin { get; set; } = false;

    [JsonPropertyName("unitOfMeasure")]
    public string UnitOfMeasure { get; set; } = string.Empty;

    [JsonPropertyName("packageQuantity")]
    public double? PackageQuantity { get; set; } = null;
}

public class Logistics
{
    [JsonPropertyName("wholesalerId")]
    public string WholesalerId { get; set; } = string.Empty;

    [JsonPropertyName("wholesalerName")]
    public string WholesalerName { get; set; } = string.Empty;

    [JsonPropertyName("vendorId")]
    public string VendorId { get; set; } = string.Empty;

    [JsonPropertyName("vendorName")]
    public string VendorName { get; set; } = string.Empty;

    [JsonPropertyName("vendorValidFrom")]
    public string VendorValidFrom { get; set; } = string.Empty;

    [JsonPropertyName("manufacturerId")]
    public string ManufacturerId { get; set; } = string.Empty;

    [JsonPropertyName("manufacturerName")]
    public string ManufacturerName { get; set; } = string.Empty;

    [JsonPropertyName("barcodes")]
    public List<Barcode> Barcodes { get; set; } = [];

    [JsonPropertyName("orderPack")]
    public string OrderPack { get; set; } = string.Empty;

    [JsonPropertyName("minimumOrderQuantity")]
    public double? MinimumOrderQuantity { get; set; } = null;

    [JsonPropertyName("packagingWeight")]
    public double? PackagingWeight { get; set; } = null;
}

public class Properties
{
    [JsonPropertyName("ecoLabellingId")]
    public string EcoLabellingId { get; set; } = string.Empty;

    [JsonPropertyName("ecoLabelling")]
    public string EcoLabelling { get; set; } = string.Empty;

    [JsonPropertyName("storagePotentialId")]
    public string StoragePotentialId { get; set; } = string.Empty;

    [JsonPropertyName("storagePotential")]
    public string StoragePotential { get; set; } = string.Empty;

    [JsonPropertyName("organic")]
    public bool Organic { get; set; } = false;

    [JsonPropertyName("biodynamic")]
    public bool Biodynamic { get; set; } = false;

    [JsonPropertyName("ethicallyCertified")]
    public bool EthicallyCertified { get; set; } = false;

    [JsonPropertyName("vintageControlled")]
    public bool VintageControlled { get; set; } = false;

    [JsonPropertyName("sweetWine")]
    public bool SweetWine { get; set; } = false;

    [JsonPropertyName("freeOrLowOnGluten")]
    public bool FreeOrLowOnGluten { get; set; } = false;

    [JsonPropertyName("kosher")]
    public bool Kosher { get; set; } = false;

    [JsonPropertyName("locallyProduced")]
    public bool LocallyProduced { get; set; } = false;

    [JsonPropertyName("noAddedSulphur")]
    public bool NoAddedSulphur { get; set; } = false;

    [JsonPropertyName("environmentallySmart")]
    public bool EnvironmentallySmart { get; set; } = false;

    [JsonPropertyName("productionMethodStorage")]
    public string ProductionMethodStorage { get; set; } = string.Empty;
}

public class Classification
{
    [JsonPropertyName("mainProductTypeId")]
    public string MainProductTypeId { get; set; } = string.Empty;

    [JsonPropertyName("mainProductTypeName")]
    public string MainProductTypeName { get; set; } = string.Empty;

    [JsonPropertyName("subProductTypeId")]
    public string SubProductTypeId { get; set; } = string.Empty;

    [JsonPropertyName("subProductTypeName")]
    public string SubProductTypeName { get; set; } = string.Empty;

    [JsonPropertyName("productTypeId")]
    public string ProductTypeId { get; set; } = string.Empty;

    [JsonPropertyName("productTypeName")]
    public string ProductTypeName { get; set; } = string.Empty;

    [JsonPropertyName("productGroupId")]
    public string ProductGroupId { get; set; } = string.Empty;

    [JsonPropertyName("productGroupName")]
    public string ProductGroupName { get; set; } = string.Empty;
}

public class Ingredient
{
    [JsonPropertyName("grapes")]
    public List<Grape> Grapes { get; set; } = [];

    [JsonPropertyName("ingredients")]
    public string Ingredients { get; set; } = string.Empty;

    [JsonPropertyName("sugar")]
    public string Sugar { get; set; } = string.Empty;

    [JsonPropertyName("acid")]
    public string Acid { get; set; } = string.Empty;

    [JsonPropertyName("allergens")]
    public string Allergens { get; set; } = string.Empty;
}

public class Grape
{
    [JsonPropertyName("grapeId")]
    public string GrapeId { get; set; } = string.Empty;

    [JsonPropertyName("grapeDesc")]
    public string GrapeDesc { get; set; } = string.Empty;

    [JsonPropertyName("grapePct")]
    public string GrapePct { get; set; } = string.Empty;
}

public class Description
{
    [JsonPropertyName("characteristics")]
    public Characteristics Characteristics { get; set; } = new();

    [JsonPropertyName("freshness")]
    public string Freshness { get; set; } = string.Empty;

    [JsonPropertyName("fullness")]
    public string Fullness { get; set; } = string.Empty;

    [JsonPropertyName("bitterness")]
    public string Bitterness { get; set; } = string.Empty;

    [JsonPropertyName("sweetness")]
    public string Sweetness { get; set; } = string.Empty;

    [JsonPropertyName("tannins")]
    public string Tannins { get; set; } = string.Empty;

    [JsonPropertyName("recommendedFood")]
    public List<RecommendedFood> RecommendedFood { get; set; } = [];
}

public class Characteristics
{
    [JsonPropertyName("colour")]
    public string Colour { get; set; } = string.Empty;

    [JsonPropertyName("odour")]
    public string Odour { get; set; } = string.Empty;

    [JsonPropertyName("taste")]
    public string Taste { get; set; } = string.Empty;
}

public class RecommendedFood
{
    [JsonPropertyName("foodId")]
    public string FoodId { get; set; } = string.Empty;

    [JsonPropertyName("foodDesc")]
    public string FoodDesc { get; set; } = string.Empty;
}

public class Assortments
{
    [JsonPropertyName("assortmentId")]
    public string AssortmentId { get; set; } = string.Empty;

    [JsonPropertyName("assortment")]
    public string Assortment { get; set; } = string.Empty;

    [JsonPropertyName("validFrom")]
    public string ValidFrom { get; set; } = string.Empty;

    [JsonPropertyName("listedFrom")]
    public string ListedFrom { get; set; } = string.Empty;

    [JsonPropertyName("assortmentGrades")]
    public List<AssortmentGrades> AssortmentGrades { get; set; } = [];
}

public class AssortmentGrades
{
    [JsonPropertyName("assortmentGrade")]
    public string AssortmentGrade { get; set; } = string.Empty;

    [JsonPropertyName("assortmentGradeDesc")]
    public string AssortmentGradeDesc { get; set; } = string.Empty;
}

public class Price
{
    [JsonPropertyName("priceValidFrom")]
    public string PriceValidFrom { get; set; } = string.Empty;

    [JsonPropertyName("salesPrice")]
    public double? SalesPrice { get; set; } = null;

    [JsonPropertyName("salesPricePrLiter")]
    public double? SalesPricePrLiter { get; set; } = null;

    [JsonPropertyName("bottleReturnValue")]
    public double? BottleReturnValue { get; set; } = null;

    [JsonPropertyName("vatAmountIncluded")]
    public double? VatAmountIncluded { get; set; } = null;
}

public class Attribute
{
    [JsonPropertyName("attributeCode")]
    public string AttributeCode { get; set; } = string.Empty;

    [JsonPropertyName("attributeDesc")]
    public string AttributeDesc { get; set; } = string.Empty;
}