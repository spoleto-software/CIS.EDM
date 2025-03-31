using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/5ecf4e4448a4731c3d3e99427d2b0d185a844a1e/#dst102344">Представитель юридического лица.</see>
    /// </summary>
    /// <value><b>ЮЛ</b> - сокращенное наименование (код) элемента.</value>
    public record LegalPersonRepresentative : SignerPersonBase
    {
        /// <summary>
        /// ИНН юридического лица.
        /// </summary>
        /// <value><b>ИННЮЛ</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Inn { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        /// <value><b>НаимОрг</b> - сокращенное наименование (код) элемента.</value>
        public string OrgName { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        /// <value><b>Должн</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string JobTitle { get; set; }
    }
}
