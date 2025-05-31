namespace CIS.EDM.Models.V5_03.Seller.Address
{
	/// <summary>
	/// Сведения о типе и наименовании адресного элемента (ТипНаимТип)
	/// </summary>
	public record AddressElementType
	{
		/// <summary>
		/// Вид элемента.
		/// </summary>
		/// <value><b>Тип</b> - сокращенное наименование (код) элемента.</value>
		public string Type { get; set; }

		/// <summary>
		/// Наименование элемента.
		/// </summary>
		/// <value><b>Наим</b> - сокращенное наименование (код) элемента.</value>
		public string Name { get; set; }
	}
}