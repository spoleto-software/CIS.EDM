namespace CIS.EDM.Models.V5_03.Seller.Address
{
	/// <summary>
	/// Сведения о виде и наименовании адресного элемента (ВидНаимТип)
	/// </summary>
	public record AddressElement
	{
		/// <summary>
		/// Вид элемента.
		/// </summary>
		/// <value><b>Вид</b> - сокращенное наименование (код) элемента.</value>
		public string Type { get; set; }

		/// <summary>
		/// Наименование элемента.
		/// </summary>
		/// <value><b>Наим</b> - сокращенное наименование (код) элемента.</value>
		public string Name { get; set; }
	}
}