using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Представитель юридического лица.</see>
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
