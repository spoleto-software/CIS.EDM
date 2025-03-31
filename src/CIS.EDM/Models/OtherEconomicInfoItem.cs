using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Текстовая <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/ffb1ea1857215c68e57e4298ddb4b44731de244f/#dst101603">информация</see>.
    /// </summary>
    /// <value><b>ТекстИнф</b> - сокращенное наименование (код) элемента.</value>
    public record OtherEconomicInfoItem
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        /// <value><b>Идентиф</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        /// <value><b>Значен</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Value { get; set; }
    }
}