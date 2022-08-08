namespace CIS.EDM.Models
{
    /// <summary>
    /// Информация об отправке сообщения в систему электронного документооборота.
    /// </summary>
    public class ResultInfo
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
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => Id ?? Content;
    }
}
