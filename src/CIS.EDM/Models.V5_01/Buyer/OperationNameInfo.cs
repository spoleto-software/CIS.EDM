using System;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Buyer.Reference;
using CIS.EDM.Models.V5_01.Buyer.Reference;

namespace CIS.EDM.Models.V5_01.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/87d4700fa0bed4fa2cdc53a5b6d8d00338147665/#dst101964">Код содержания операции.</see>
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
        /// Наименование документа, оформляющего расхождения.
        /// </summary>
        /// <value><b>НаимДокРасх</b> - сокращенное наименование (код) элемента.</value>
        public string DiscrepancyDocumentName { get; set; }

        /// <summary>
        /// Код вида документа о расхождениях.
        /// </summary>
        /// <value><b>ВидДокРасх</b> - сокращенное наименование (код) элемента.</value>
        public DiscrepancyDocumentCode DiscrepancyDocumentCode { get; set; } = DiscrepancyDocumentCode.NotSpecified;

        /// <summary>
        /// Номер документа покупателя о расхождениях.
        /// </summary>
        /// <value><b>НомДокРасх</b> - сокращенное наименование (код) элемента.</value>
        public string DiscrepancyDocumentNumber { get; set; }

        /// <summary>
        /// Дата документа о расхождениях.
        /// </summary>
        /// <value><b>ДатаДокРасх</b> - сокращенное наименование (код) элемента.</value>
        public DateTime? DiscrepancyDocumentDate { get; set; }

        /// <summary>
        /// Идентификатор файла обмена документа о расхождениях, сформированного покупателем.
        /// </summary>
        /// <value><b>ИдФайлДокРасх</b> - сокращенное наименование (код) элемента.</value>
        public string DiscrepancyDocumentId { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{Code}.";
    }
}
