using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Сведения об иностранном лице, не состоящем на учете в налоговых органах в качестве налогоплательщика.</see>
	/// </summary>
	/// <value><b>СвИнНеУч</b> - сокращенное наименование (код) элемента.</value>
	public record ForeignPerson
    {
        /// <summary>
        /// Наименование полное.
        /// </summary>
        /// <value><b>НаимОрг</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор юридического лица-нерезидента
        /// </summary>
        /// <remarks>
        /// Информация для автоматизированной обработки.
        /// </remarks>
        /// <value><b>Идентиф</b> - сокращенное наименование (код) элемента.</value>
        public string LegalEntityId { get; set; }

        /// <summary>
        /// Иные сведения, идентифицирующие юридическое лицо.
        /// </summary>
        /// <remarks>
        /// В частности, может быть указана страна при отсутствии КодСтр.
        /// </remarks>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string OtherInfo { get; set; }
    }
}