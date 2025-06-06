namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Сведения о физическом лице.</see>
	/// </summary>
	/// <value><b>ФЛ</b> - сокращенное наименование (код) элемента.</value>
	public record PhysicalPerson : Person
	{
		/// <summary>
		/// ИНН физического лица.
		/// </summary>
		/// <remarks>
		/// Обязателен при отсутствии ИныеСвед и ФИО, кроме ИдСтатЛ=0.
		/// </remarks>
		/// <value><b>ИННФЛ</b> - сокращенное наименование (код) элемента.</value>
		public string Inn { get; set; }

		/// <summary>
		/// Идентификация статуса лица.
		/// </summary>
		/// <remarks>
		/// Возможные значения:
		/// '0' – лицо, являющееся покупателем при розничной продаже,
		/// '1' – иное.
		/// </remarks>
		/// <value><b>ИдСтатЛ</b> - сокращенное наименование (код) элемента.</value>
		public string Status { get; set; }

		/// <summary>
		/// Иные сведения, идентифицирующие физическое лицо.
		/// </summary>
		/// <remarks>
		/// Элемент обязателен при отсутствии ФИО, кроме ИдСтатЛ=0
		/// </remarks>
		/// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
		public string OtherInfo { get; set; }
	}
}
