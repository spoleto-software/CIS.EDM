﻿using System.Text.Json.Serialization;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Вариант сортировки.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortField
    {
        /// <summary>
        /// время создания документа (параметр сортировки по умолчанию);
        /// </summary>
        created_at,

        /// <summary>
        /// дата документа;
        /// </summary>
        date,

        /// <summary>
        /// контрагент (для исходящего документа это получатель, для входящего - отправитель);
        /// </summary>
        partner_name,

        /// <summary>
        /// тип документа (сортировка выполняется не по названию, а по цифровому коду типа);
        /// </summary>
        type,

        /// <summary>
        /// статус документа (сортировка выполняется не по названию, а по цифровому коду статуса)
        /// </summary>
        status
    }
}
