using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Дополнительные сведения о товаре, подлежащем идентификации и учету в государственной информационной системе (СвГосСист)
	/// </summary>
	public record GovernmentSystemAdditionalInfo
	{
		/// <summary>
		/// Наименование государственной информационной системы
		/// </summary>
		/// <value><b>НаимГосСист</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string InformationSystemName { get; set; }

		/// <summary>
		/// Учетная единица в государственной информационной системе
		/// </summary>
		/// <value><b>УчетЕд</b> - сокращенное наименование (код) элемента.</value>
		public string AccountingUnit { get; set; }

		/// <summary>
		/// Иная информация о товаре, подлежащем учету в государственной информационной системе
		/// </summary>
		/// <value><b>ИнаяИнф</b> - сокращенное наименование (код) элемента.</value>
		public string OtherInfo { get; set; }

		/// <summary>
		/// Идентификационный номер учетной единицы в государственной информационной системе
		/// </summary>
		/// <value><b>ИдНомУчетЕд</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public List<string> AccountingUnitIds { get; set; }
	}
}