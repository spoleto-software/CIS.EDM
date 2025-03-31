using System;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Информация об отправке сообщения в систему электронного документооборота.
    /// </summary>
    public record ResultInfo
    {
        /// <summary>
        /// Идентификатор сообщения
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Тело сообщения.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Ошибка отправки сообщения.
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => Id ?? Exception?.Message;
    }
}
