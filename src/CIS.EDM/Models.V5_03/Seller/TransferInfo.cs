using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Содержание факта хозяйственной жизни 3 - сведения о факте отгрузки товаров (выполнения работ), передачи имущественных прав (о предъявлении оказанных услуг) (СвПродПер).
	/// </summary>
	/// <value><b>СвПродПер</b> - сокращенное наименование (код) элемента.</value>
	public record TransferInfo
	{
		/// <summary>
		/// Сведения о передаче (сдаче) товаров (результатов работ), имущественных прав (о предъявлении оказанных услуг)
		/// </summary>
		/// <value><b>СвПер</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public TransferDetails TransferDetails { get; set; } // СвПер

		/// <summary>
		/// Информационное поле факта хозяйственной жизни 3
		/// </summary>
		/// <value><b>ИнфПолФХЖ3</b> - сокращенное наименование (код) элемента.</value>
		public OtherEconomicInfo3 OtherEconomicInfo { get; set; }

		/// <summary>
		/// Текстовое представление объекта.
		/// </summary>
		public override string ToString() => $"{TransferDetails}";
	}
}