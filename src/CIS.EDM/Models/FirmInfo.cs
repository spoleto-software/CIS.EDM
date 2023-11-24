using System.Text.Json.Serialization;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Информация о покупателе
    /// </summary>
    public class FirmInfo
    {
        /// <summary>
        /// Идентификатор получателя в системе ЭДО оператора
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

		/// <summary>
		/// Доп. идентификатор
		/// </summary>
		[JsonPropertyName("extra_id")]
		public string ExtraId { get; set; }

		/// <summary>
		/// ИНН получателя
		/// </summary>
		[JsonPropertyName("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП получателя
        /// </summary>
        [JsonPropertyName("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// ОГРН получателя
        /// </summary>
        [JsonPropertyName("ogrn")]
        public string Ogrn { get; set; }

        /// <summary>
        /// Наименование получателя
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// E-mail получателя
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => Name;
    }
}