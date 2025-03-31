using System;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.V5_03.Buyer.Reference;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Код содержания операции.</see>
	/// </summary>
	/// <value><b>КодСодОпер</b> - сокращенное наименование (код) элемента.</value>
	public record OperationNameInfo
    {
        /// <summary>
        /// Код, обозначающий итог приемки товара (работ, услуг, прав).
        /// </summary>
        /// <value><b>КодИтога</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public OperationNameCode Code { get; set; } = OperationNameCode.Accepted;

		/// <summary>
		/// Реквизиты документа, оформляющего расхождения.
		/// </summary>
		/// <value><b>РеквДокРасх</b> - сокращенное наименование (код) элемента.</value>
		public Document DiscrepancyDocument { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{Code}.";
    }
}
