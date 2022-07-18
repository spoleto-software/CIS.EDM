using System;
using System.Text.Json.Serialization;
using CIS.EDM.JsonConverters;
using CIS.EDM.Models.Reference;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Информация о документе в системе ЭДО оператора
    /// </summary>
    public class DocumentInfo
    {
        /// <summary>
        /// Идентификатор документа в системе ЭДО оператора
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Дата создания документа в формате timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Дата документа в формате timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Дата последней обработки документа в формате timestamp
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonPropertyName("processed_at")]
        public DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Числовой статус документа см.Справочник "Статусы документов"
        /// </summary>
        [JsonPropertyName("status")]
        public DocumentState Status { get; set; }

        /// <summary>
        /// Цена с НДС
        /// </summary>
        [JsonPropertyName("total_price")]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        [JsonPropertyName("total_vat_amount")]
        public decimal TotalVatAmount { get; set; }

        /// <summary>
        /// Код типа документа Справочник "Типы документов"
        /// </summary>
        [JsonPropertyName("type")]
        public DocumentType Type { get; set; }

        /// <summary>
        /// Документ подписан получателем
        /// </summary>
        [JsonPropertyName("is_title_signed")]
        public bool? IsTitleSigned { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => Number;
    }
}