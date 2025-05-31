using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller.Address
{
	/// <summary>
	/// Адрес, указанный в Едином государственном реестре юридических лиц/почтовый адрес/адрес регистрации по месту жительства (по месту пребывания) индивидуального предпринимателя, указанный в Едином государственном реестре индивидуальных предпринимателей (информация об адресе, в том числе об адресе за пределами территории Российской Федерации).
	/// </summary>
	/// <value><b>АдрИнф</b> - сокращенное наименование (код) элемента.</value>
	public record AddressInformation
    {
		/// <summary>
		/// Код страны.
		/// </summary>
		/// <remarks>
		/// Принимает значение в соответствии с Общероссийским классификатором стран мира (ОКСМ).
		/// </remarks>
		/// <value><b>КодСтр</b> - сокращенное наименование (код) элемента.</value>
		[Required]
        public string CountryCode { get; set; }

		/// <summary>
		/// Наименование страны.
		/// </summary>
		/// <remarks>
		/// Принимает значение в соответствии с Общероссийским классификатором стран мира (ОКСМ).
		/// </remarks>
		/// <value><b>НаимСтран</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string CountryName { get; set; }

		/// <summary>
		/// Адрес.
		/// </summary>
		/// <value><b>АдрТекст</b> - сокращенное наименование (код) элемента.</value>
		[Required]
        public string Address { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{CountryCode}: {Address}";
    }
}