﻿using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_01.Seller
{
    /// <summary>
    /// Сведения о товаре, подлежащем <see href="https://www.consultant.ru/document/cons_doc_LAW_316356/9e462a44b62c07e3b89bb3092b20ef24f5420e32/">прослеживаемости</see>.
    /// </summary>
    /// <value><b>СведПрослеж</b> - сокращенное наименование (код) элемента.</value>
    public record InvoiceItemTracingInfo
    {
        /// <summary>
        /// Регистрационный номер партии товаров
        /// </summary>
        /// <remarks>
        /// Номер, формируемый из показателей декларации на товары или заявления о выпуске товаров до подачи декларации на товары
        /// (регистрационный номер декларации на товары (регистрационный номер заявления) и порядковый номер товара),
        /// либо номер, присваиваемый налоговым (таможенным) органом товару, подлежащему прослеживаемости.
        /// </remarks>
        /// <value><b>НомТовПрослеж</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string RegNumberUnit { get; set; }

        /// <summary>
        /// Единица количественного учета товара, используемая в целях осуществления прослеживаемости.
        /// </summary>
        /// <remarks>
        /// Принимает значение в соответствии с Общероссийским классификатором единиц измерения.
        /// </remarks>
        /// <value><b>ЕдИзмПрослеж</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string UnitCode { get; set; }

        /// <summary>
        /// Наименование единицы количественного учета товара, используемой в целях осуществления прослеживаемости.
        /// </summary>
        /// <remarks>
        /// Формируется автоматически в соответствии с указанным <see cref="UnitCode"/>.
        /// </remarks>
        /// <value><b>НаимЕдИзмПрослеж</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string UnitName { get; set; }

        /// <summary>
        /// Количество товара в единицах измерения прослеживаемого товара.
        /// </summary>
        /// <value><b>КолВЕдПрослеж</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Дополнительный показатель для идентификации товаров, подлежащих прослеживаемости.
        /// </summary>
        /// <value><b>ДопПрослеж</b> - сокращенное наименование (код) элемента.</value>
        public string AdditionalInfo { get; set; }
    }
}