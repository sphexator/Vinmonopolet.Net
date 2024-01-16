using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForRecommendedFoodResponse
{
	[JsonPropertyName("foodId")]
	public string FoodId { get; set; } = string.Empty;

	[JsonPropertyName("foodDesc")]
	public string FoodDesc { get; set; } = string.Empty;
}