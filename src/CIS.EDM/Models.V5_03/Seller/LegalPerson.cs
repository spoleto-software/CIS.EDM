using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Сведения о юридическом лице, состоящем на учете в налоговых органах.</see>
	/// </summary>
	/// <value><b>СвЮЛУч</b> - сокращенное наименование (код) элемента.</value>
	public record LegalPerson
    {
        /// <summary>
        /// Наименование полное.
        /// </summary>
        /// <value><b>НаимОрг</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <value><b>ИННЮЛ</b> - сокращенное наименование (код) элемента.</value>
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        /// <remarks>
        /// Обязателен для лиц, состоящих на учете в налоговых органах
        /// </remarks>
        /// <value><b>КПП</b> - сокращенное наименование (код) элемента.</value>
        public string Kpp { get; set; }
    }
}