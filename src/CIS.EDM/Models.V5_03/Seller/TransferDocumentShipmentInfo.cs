using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Реквизиты <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">документа, подтверждающего отгрузку товаров (работ, услуг, имущественных прав).</see> 
	/// </summary>
	/// <remarks>
	/// Документ об отгрузке (графа 5а в счёт-фактуре).
	/// </remarks>
	/// <value><b>ДокПодтвОтгр</b> - сокращенное наименование (код) элемента.</value>
	public record TransferDocumentShipmentInfo
    {
        /// <summary>
        /// Наименование документа об отгрузке
        /// </summary>
        /// <value><b>НаимДокОтгр</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Номер документа об отгрузке
        /// </summary>
        /// <value><b>НомДокОтгр</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Дата документа об отгрузке.
        /// </summary>
        /// <remarks>
        /// Дата в формате ДД.ММ.ГГГГ.
        /// </remarks>
        /// <value><b>ДатаДокОтгр</b> - сокращенное наименование (код) элемента.</value>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{Name} №<{Number}> от <{Date}>.";
    }
}