using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// Реквизиты <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/c7010b103c6b43534d190146b898dd63c48c04d8/">документа, подтверждающего отгрузку товаров (работ, услуг, имущественных прав).</see> 
    /// </summary>
    /// <remarks>
    /// Документ об отгрузке (графа 5а в счёт-фактуре).
    /// </remarks>
    /// <value><b>ДокПодтвОтгр</b> - сокращенное наименование (код) элемента.</value>
    public class TransferDocumentShipmentInfo
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