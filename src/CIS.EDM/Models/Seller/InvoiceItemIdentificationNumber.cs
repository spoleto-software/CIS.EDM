using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Seller.Reference;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// Номер средств <see href="https://www.consultant.ru/document/cons_doc_LAW_316356/278c40ea9d936ea9302c20ff1debe7a95a606a0e/">идентификации товаров</see> (информация о маркировке).
    /// </summary>
    /// <value><b>НомСредИдентТов</b> - сокращенное наименование (код) элемента.</value>
    public class InvoiceItemIdentificationNumber
    {
        /// <summary>
        /// Уникальный идентификатор транспортной упаковки
        /// </summary>
        /// <remarks>
        /// Например, SSCC.<br/>
        /// Обязателен при отсутствии <see cref="MarkItems"/> и <see cref="SecondaryPackageItems"/>.
        /// </remarks>
        /// <value><b>ИдентТрансУпак</b> - сокращенное наименование (код) элемента.</value>
        public string PackageId { get; set; }

        /// <summary>
        /// Контрольный идентификационный знак (КИЗ).
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="PackageId"/> и <see cref="SecondaryPackageItems"/>.
        /// </remarks>
        /// <value>
        /// <b>КИЗ</b> - сокращенное наименование (код) элемента.<br/>
        /// </value>
        public List<string> MarkItems { get; set; }

        /// <summary>
        /// Уникальный идентификатор вторичной (потребительской)/третичной (заводской, транспортной) упаковки.
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="PackageId"/> и <see cref="MarkItems"/>.
        /// </remarks>
        /// <value>
        /// <b>НомУпак</b> - сокращенное наименование (код) элемента.
        /// </value>
        public List<string> SecondaryPackageItems { get; set; }
    }
}