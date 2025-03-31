using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CIS.EDM.JsonConverters;
using CIS.EDM.Models.Common.Reference;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Информация для поиска документов
    /// </summary>
    public record DocumentCollectionSearchModel
    {
        /// <summary>
        /// Количество возвращаемых документов
        /// </summary>
        /// <remarks>
        /// По умолчанию 10
        /// </remarks>
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Позиция смещения в наборе результатов для начала нумерации страниц
        /// </summary>
        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Нижняя граница фильтрации документов по времени создания
        /// </summary>
        /// <remarks>
        /// В выборку попадут документы, время создания которых больше или равно указанному
        /// </remarks>
        [JsonConverter(typeof(UnixNullableDateTimeConverter))]
        [JsonPropertyName("created_from")]
        public DateTime? CreatedFrom { get; set; }

        /// <summary>
        /// Верхняя граница фильтрации документов по времени создания
        /// </summary>
        /// <remarks>
        /// В выборку попадут документы, время создания которых меньше или равно указанному
        /// </remarks>
        [JsonConverter(typeof(UnixNullableDateTimeConverter))]
        [JsonPropertyName("created_to")]
        public DateTime? CreatedTo { get; set; }

        /// <summary>
        /// ИНН контрагента
        /// </summary>
        /// <remarks>
        /// Для исходящего документа это получатель, 
        /// для входящего - отправитель
        /// </remarks>
        [JsonPropertyName("partner_inn")]
        public string PartnerInn { get; set; }

        /// <summary>
        /// Цифровое обозначение статуса возвращаемых документов
        /// </summary>
        /// <remarks>
        /// см.Справочник "Статусы документов" <see cref="DocumentState"/>
        /// </remarks>
        [JsonPropertyName("status")]
        public List<DocumentState> Status { get; set; }

        /// <summary>
        /// Цифровое обозначение типа создаваемых документов
        /// </summary>
        /// <remarks>
        /// см.Справочник "Типы документов" <see cref="DocumentType"/>
        /// </remarks>
        [JsonPropertyName("type")]
        public List<DocumentType> Type { get; set; }

        /// <summary>
        /// Параметр, по которому необходимо отсортировать возвращаемый список документов
        /// </summary>
        /// <remarks>
        /// Допустимые значения:
        /// created_at - время создания документа (параметр сортировки по умолчанию);
        /// date - дата документа;
        /// partner_name - контрагент (для исходящего документа это получатель, для входящего - отправитель);
        /// type - тип документа (сортировка выполняется не по названию, а по цифровому коду типа);
        /// status - статус документа (сортировка выполняется не по названию, а по цифровому коду статуса)
        /// </remarks>
        [JsonPropertyName("sortBy")]
        public SortField? SortBy { get; set; }

        /// <summary>
        /// Параметр, определяющий направление сортировки
        /// </summary>
        /// <remarks>
        /// Допустимые значения: false - по убыванию (значение по умолчанию), true - по возрастанию.
        /// </remarks>
        [JsonPropertyName("asc")]
        public bool? Asc { get; set; }
    }
}
