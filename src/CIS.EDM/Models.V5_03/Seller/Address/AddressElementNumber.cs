namespace CIS.EDM.Models.V5_03.Seller.Address
{
	/// <summary>
	/// Сведения о номере адресного элемента (НомерТип)
	/// </summary>
	public record AddressElementNumber
	{
		/// <summary>
		/// Вид элемента.
		/// </summary>
		/// <value><b>Тип</b> - сокращенное наименование (код) элемента.</value>
		public string Type { get; set; }

		/// <summary>
		/// Номер элемента.
		/// </summary>
		/// <value><b>Номер</b> - сокращенное наименование (код) элемента.</value>
		public string Number { get; set; }
	}
}