using System.Text.Json.Serialization;

namespace Vinmonopolet.Entities.Results.MyProducts;

public class GetCodeListForAssortmentGradeResponse
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("assortmentGrade")]
	public string AssortmentGrade { get; set; }

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("assortmentGradeDesc")]
	public string AssortmentGradeDesc { get; set; }
}