using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Транспортная накладная.</see>
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