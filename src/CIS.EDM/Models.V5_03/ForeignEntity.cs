using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Сведения об иностранном лице, не состоящем на учете в налоговых органах в качестве налогоплательщика.</see>
	/// </summary>
	/// <value><b>СвИнНеУч</b> - сокращенное наименование (код) элемента.</value>
	public record ForeignEntity
    {
		/// <summary>
		/// Идентификация статуса.
		/// </summary>
		/// <remarks>
		/// Принимает значение:
		/// "ИО" – иностранная организация
		/// "ИГ" – иностранный гражданин
		/// </remarks>
		/// <value><b>ИдСтат</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string Status { get; set; }

		/// <summary>
		/// Код страны.
		/// </summary>
		/// <remarks>
		/// Значение в соответствии с Общероссийским классификатором стран мира (ОКСМ)
		/// </remarks>
		/// <value><b>КодСтр</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string CountryCode { get; set; }

		/// <summary>
		/// Наименование страны.
		/// </summary>
		/// <remarks>
		/// Значение в соответствии с Общероссийским классификатором стран мира (ОКСМ)
		/// </remarks>
		/// <value><b>НаимСтран</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string CountryName { get; set; }

		/// <summary>
		/// Наименование полное.
		/// </summary>
		/// <value><b>НаимОрг</b> - сокращенное наименование (код) элемента.</value>
		[Required]
        public string Name { get; set; }

		/// <summary>
		/// Идентификатор иностранной организации (иностранного гражданина)
		/// </summary>
		/// <remarks>
		/// Элемент обязателен при отсутствии <see cref="OtherInfo"/>.
		/// </remarks>
		/// <value><b>Идентиф</b> - сокращенное наименование (код) элемента.</value>
		public string Identifier { get; set; }

		/// <summary>
		/// Иные сведения для однозначной идентификации иностранной организации (иностранного гражданина).
		/// </summary>
		/// <remarks>
		/// Элемент обязателен при отсутствии <see cref="Identifier"/>.
		/// </remarks>
		/// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
		public string OtherInfo { get; set; }
	}
}