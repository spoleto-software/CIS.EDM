﻿using System.Collections.Generic;
using CIS.EDM.Models.Seller.Reference;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// Дополнительные сведения об <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/2fceb17c7e6af54052d079494238454102f38a65/#dst100652">отгруженных товарах</see> (выполненных работах, оказанных услугах), переданных имущественных правах.
    /// </summary>
    /// <value><b>ДопСведТов</b> - сокращенное наименование (код) элемента.</value>
    public class AdditionalInfo
    {
        /// <summary>
        /// Признак
        /// </summary>
        /// <remarks>
        /// Товар/Работа/Услуга/Право/Иное
        /// </remarks>
        /// <value><b>ПрТовРаб</b> - сокращенное наименование (код) элемента.</value>
        public InvoiceItemType Type { get; set; }

        /// <summary>
        /// Дополнительная информация о признаке
        /// </summary>
        /// <remarks>
        /// Содержит информацию, позволяющую сторонам в автоматизированном режиме обрабатывать информацию
        /// о признаке отгруженных товаров (выполненных работ, оказанных услуг), переданных имущественных прав.
        /// </remarks>
        /// <value><b>ДопПризн</b> - сокращенное наименование (код) элемента.</value>
        public string AdditionalTypeInfo { get; set; }

        /// <summary>
        /// Наименование единицы измерения (условное обозначение национальное, графа 2а счета-фактуры)
        /// </summary>
        /// <remarks>
        /// Обязателен при наличии <see cref="InvoiceItem.UnitCode"/>.<br/>
        /// Формируется автоматически в соответствии с указанным <see cref="InvoiceItem.UnitCode"/>.<br/><br/>
        /// При <see cref="InvoiceItem.UnitCode"/>=0000 автоматическое формирование наименования единицы измерения не производится.
        /// Наименование единицы измерения указывается пользователем.<br/><br/>
        /// При составлении документа с Функция=СЧФ или Функция=СЧФДОП при отсутствии данных ставится знак "-" (дефис) (визуализируется как прочерк).
        /// </remarks>
        /// <value><b>НаимЕдИзм</b> - сокращенное наименование (код) элемента.</value>
        public string UnitName { get; set; }

        /// <summary>
        /// Краткое наименование страны происхождения товара (графа 10а счета-фактуры)/страна регистрации производителя товара
        /// </summary>
        /// <remarks>
        /// Обязателен при наличии <see cref="CustomsDeclaration.CountryCode"/>.<br/>
        /// Формируется автоматически в соответствии с указанным <see cref="CustomsDeclaration.CountryCode"/>.<br/><br/>
        /// Обязателен при осуществлении закупок для обеспечения государственных и муниципальных нужд для любой страны происхождения.
        /// </remarks>
        /// <value><b>КрНаимСтрПр</b> - сокращенное наименование (код) элемента.</value>
        public string CountryName { get; set; }

        /// <summary>
        /// Заказанное количество (количество надлежит отпустить)
        /// </summary>
        /// <value><b>НадлОтп</b> - сокращенное наименование (код) элемента.</value>
        public decimal? ItemToRelease { get; set; }

        /// <summary>
        /// Характеристика/описание товара (в том числе графа 1 счета-фактуры)
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="InvoiceItem.ProductName"/> и <see cref="Code"/> и <see cref="Article"/>.<br/>
        /// При осуществлении закупок для обеспечения государственных и муниципальных нужд описание товара
        /// приводится в соответствии с Каталогом товаров, работ, услуг (если есть в Каталоге).
        /// </remarks>
        /// <value><b>ХарактерТов</b> - сокращенное наименование (код) элемента.</value>
        public string Characteristic { get; set; }

        /// <summary>
        /// Сорт товара
        /// </summary>
        /// <value><b>СортТов</b> - сокращенное наименование (код) элемента.</value>
        public string Kind { get; set; }

        /// <summary>
        /// Артикул товара (в том числе графа 1 счета-фактуры)
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="InvoiceItem.ProductName"/> и <see cref="Characteristic"/> и <see cref="Code"/>.
        /// </remarks>
        /// <value><b>АртикулТов</b> - сокращенное наименование (код) элемента.</value>
        public string Article { get; set; }

        /// <summary>
        /// Код товара (в том числе графа 1 счета-фактуры)
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="InvoiceItem.ProductName"/> и <see cref="Characteristic"/> и <see cref="Article"/>.<br/>
        /// При осуществлении закупок для обеспечения государственных и муниципальных нужд приводится в соответствии с
        /// Каталогом товаров, работ, услуг (если есть в Каталоге)
        /// </remarks>
        /// <value><b>КодТов</b> - сокращенное наименование (код) элемента.</value>
        public string Code { get; set; }

        /// <summary>
        /// Код каталога
        /// </summary>
        /// <remarks>
        /// Заполняется при осуществлении закупок для обеспечения государственных и муниципальных нужд.
        /// </remarks>
        /// <value><b>КодКат</b> - сокращенное наименование (код) элемента.</value>
        public string CatalogCode { get; set; }

        /// <summary>
        /// Код вида товара
        /// </summary>
        /// <remarks>
        /// Принимает значение согласно Товарной номенклатуре внешнеэкономической деятельности (ТН ВЭД).<br/>
        /// Обязательно указание значения в случае отражения в счете-фактуре товаров, 
        /// вывезенных за пределы территории Российской Федерации на территорию государства - члена Евразийского экономического союза.<br/><br/>
        /// При отсутствии значения ставится знак "-" (дефис) (визуализируется как прочерк).
        /// </remarks>
        /// <value><b>КодВидТов</b> - сокращенное наименование (код) элемента.</value>
        public string FeaccCode { get; set; }

        /// <summary>
        /// Сведения о товаре, подлежащем прослеживаемости
        /// </summary>
        /// <value><b>СведПрослеж</b> - сокращенное наименование (код) элемента.</value>
        public List<InvoiceItemTracingInfo> ItemTracingInfoList { get; set; }

        /// <summary>
        /// Номер средств идентификации товаров (КИЗы).
        /// </summary>
        /// <remarks>
        /// Обязателен для товаров, включенных в систему маркировки.
        /// </remarks>
        /// <value><b>НомСредИдентТов</b> - сокращенное наименование (код) элемента.</value>
        public List<InvoiceItemIdentificationNumber> ItemIdentificationNumberList { get; set; }
    }
}