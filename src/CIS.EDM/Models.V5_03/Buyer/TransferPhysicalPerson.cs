using CIS.EDM.Models.Common;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Физическое лицо</see>, которому доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
	/// </summary>
	/// <value><b>ФЛПер</b> - сокращенное наименование (код) элемента.</value>
	public record TransferPhysicalPerson : Person
	{
		/// <summary>
		/// ИНН физического лица, в том числе индивидуального предпринимателя, которому доверен прием.
		/// </summary>
		/// <value><b>ИННФЛПрин</b> - сокращенное наименование (код) элемента.</value>
		public string PersonInn { get; set; }

		/// <summary>
		/// Иные сведения, идентифицирующие физическое лицо.
		/// </summary>
		/// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
		public string PersonInfo { get; set; }

		/// <summary>
		/// Основание, по которому физическому лицу доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
		/// </summary>
		/// <value><b>ОснДоверФЛ</b> - сокращенное наименование (код) элемента.</value>
		public Document PersonBase { get; set; }
	}
}
