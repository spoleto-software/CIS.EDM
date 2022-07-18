using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/21e1fe3ec684d130dda83c2952898fd424a666c1/#dst101310">Сведения об иностранном лице, не состоящем на учете в налоговых органах в качестве налогоплательщика.</see>
    /// </summary>
    /// <value><b>СвИнНеУч</b> - сокращенное наименование (код) элемента.</value>
    public class ForeignPerson
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