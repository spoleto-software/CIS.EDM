using CIS.EDM.Models;
using System;

namespace CIS.EDM.Models.V5_03
{
	/// <summary>
	/// Сведения о доверенности в форме документа на бумажном носителе, используемой для подтверждения полномочий представителя (СвДоверБум).
	/// </summary>
	public record PaperPoAInfo
	{
		/// <summary>
		/// Дата совершения (выдачи) доверенности.
		/// </summary>
		/// <value><b>ДатаВыдДовер</b> - сокращенное наименование (код) элемента.</value>
		public DateTime IssueDate { get; set; }

		/// <summary>
		/// Внутренний номер доверенности.
		/// </summary>
		/// <remarks>
		/// При отсутствии номера принимает значение: без номера (б/н).
		/// </remarks>
		/// <value><b>ВнНомДовер</b> - сокращенное наименование (код) элемента.</value>
		public string InternalNumber { get; set; }

		/// <summary>
		/// Сведения, идентифицирующие доверителя.
		/// </summary>
		/// <value><b>СвИдДовер</b> - сокращенное наименование (код) элемента.</value>
		public string TrusteeInfo { get; set; }

		/// <summary>
		/// Фамилия, имя, отчество (при наличии) лица, подписавшего доверенность.
		/// </summary>
		/// <value><b>ФИО</b> - сокращенное наименование (код) элемента.</value>
		public Person Signer { get; set; }
	}
}