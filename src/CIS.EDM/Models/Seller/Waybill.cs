using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/96a565c13bd5dd139748898fdadf6e5468e5d645/#dst101058">Транспортная накладная.</see>
    /// </summary>
    /// <value><b>ТранНакл</b> - сокращенное наименование (код) элемента.</value>
    public record Waybill
    {
        /// <summary>
        /// Номер транспортной накладной.
        /// </summary>
        /// <value><b>НомТранНакл</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string TransferDocumentNumber { get; set; }

        /// <summary>
        /// Дата транспортной накладной.
        /// </summary>
        /// <value><b>ДатаТранНакл</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public DateTime TransferDocumentDate { get; set; }
    }
}