using CIS.EDM.Models;
using CIS.EDM.Models.V5_03.Reference;
using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03
{
	/// <summary>
	/// Сведения о лице, подписывающем файл обмена счета-фактуры в электронной форме
	/// </summary>
	/// <value><b>Подписант</b> - сокращенное наименование (код) элемента.</value>
	public record SignerBase
	{
		/// <summary>
		/// Должность.
		/// </summary>
		/// <value><b>Должн</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string JobTitle { get; set; }

		/// <summary>
		/// Тип подписи.
		/// </summary>
		/// <value><b>ТипПодпис</b> - сокращенное наименование (код) элемента.</value>
		public SignatureType? SignatureType { get; set; }

		/// <summary>
		/// Дата подписания документа.
		/// </summary>
		/// <value><b>ДатаПодДок</b> - сокращенное наименование (код) элемента.</value>
		public DateTime? SigningDate { get; set; }

		/// <summary>
		/// Способ подтверждения полномочий представителя на подписание документа.
		/// </summary>
		/// <value><b>СпосПодтПолном</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public AuthorityConfirmationType AuthorityConfirmationType { get; set; } // СпосПодтПолном

		/// <summary>
		/// Дополнительные сведения.
		/// </summary>
		/// <value><b>ДопСведПодп</b> - сокращенное наименование (код) элемента.</value>
		public string AdditionalInfo { get; set; } // ДопСведПодп

		/// <summary>
		/// Фамилия, имя, отчество (при наличии).
		/// </summary>
		/// <value><b>ФИО</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public Person Person { get; set; } // ФИО

		/// <summary>
		/// Сведения о доверенности в электронной форме в машиночитаемом виде, используемой для подтверждения полномочий представителя.
		/// </summary>
		/// <value><b>СвДоверЭл</b> - сокращенное наименование (код) элемента.</value>
		public ElectronicPoAInfo? ElectronicPoAInfo { get; set; }

		/// <summary>
		/// Сведения о доверенности в форме документа на бумажном носителе, используемой для подтверждения полномочий представителя.
		/// </summary>
		/// <value><b>СвДоверБум</b> - сокращенное наименование (код) элемента.</value>
		public PaperPoAInfo? PaperPoAInfo { get; set; }
	}
}
