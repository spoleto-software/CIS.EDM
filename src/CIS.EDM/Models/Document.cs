using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CIS.EDM.JsonConverters;
using CIS.EDM.Models.Reference;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Информация о последнем документе.
    /// </summary>
    public record Document
    {
        /// <summary>
        /// Идентификатор последнего документа цепочки
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Дата создания последнего документа цепочки в формате timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Дата последнего документа цепочки в формате timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Информация о документе в системе ЭДО оператора
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DocumentInfo> Documents { get; set; }

        /// <summary>
        /// Идентификатор группы цепочки документов
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// Номер последнего документа в цепочке
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Информация о покупателе
        /// </summary>
        [JsonPropertyName("sender")]
        public FirmInfo Sender { get; set; }

        /// <summary>
        /// Числовой статус последнего документа цепочки см.Справочник "Статусы документов"
        /// </summary>
        [JsonPropertyName("status")]
        public DocumentState Status { get; set; }

        /// <summary>
        /// Общая сумма c НДС
        /// </summary>
        [JsonPropertyName("total_price")]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Общая сумма НДС
        /// </summary>
        [JsonPropertyName("total_vat_amount")]
        public decimal TotalVatAmount { get; set; }

        /// <summary>
        /// Код типа документа последнего в цепочке см.Справочник "Типы документов"
        /// </summary>
        [JsonPropertyName("type")]
        public DocumentType Type { get; set; }

        /// <summary>
        /// Дата создания документа в формате timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("create_time_stamp")]
        public DateTime CreateTimestamp { get; set; }

        /// <summary>
        /// Дата последней обработки документа в секундах
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("export_time_stamp")]
        public DateTime ExportTimestamp { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => Number;
    }
}