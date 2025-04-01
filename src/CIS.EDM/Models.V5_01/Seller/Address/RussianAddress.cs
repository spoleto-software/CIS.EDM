using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_01.Seller.Address
{
    /// <summary>
    /// Адрес, указанный в Едином государственном реестре юридических лиц/почтовый адрес/адрес места жительства индивидуального предпринимателя (реквизиты адреса на территории Российской Федерации).
    /// </summary>
    /// <value><b>АдрРФ</b> - сокращенное наименование (код) элемента.</value>
    public record RussianAddress
    {
        /// <summary>
        /// Индекс.
        /// </summary>
        /// <value><b>Индекс</b> - сокращенное наименование (код) элемента.</value>
        public string ZipCode { get; set; }

		/// <summary>
		/// Регион.
		/// </summary>
		/// <value><b>НаимРегион</b> - сокращенное наименование (код) элемента.</value>
		[Required]
        public string Region { get; set; }

		/// <summary>
		/// Код региона.
		/// </summary>
		/// <value><b>КодРегион</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string RegionCode { get; set; }

		/// <summary>
		/// Район.
		/// </summary>
		/// <value><b>Район</b> - сокращенное наименование (код) элемента.</value>
		public string Territory { get; set; }

        /// <summary>
        /// Город.
        /// </summary>
        /// <value><b>Город</b> - сокращенное наименование (код) элемента.</value>
        public string City { get; set; }

        /// <summary>
        /// Населенный пункт.
        /// </summary>
        /// <value><b>НаселПункт</b> - сокращенное наименование (код) элемента.</value>
        public string Locality { get; set; }

        /// <summary>
        /// Улица.
        /// </summary>
        /// <value><b>Улица</b> - сокращенное наименование (код) элемента.</value>
        public string Street { get; set; }

        /// <summary>
        /// Дом.
        /// </summary>
        /// <value><b>Дом</b> - сокращенное наименование (код) элемента.</value>
        public string Building { get; set; }

        /// <summary>
        /// Корпус.
        /// </summary>
        /// <value><b>Корпус</b> - сокращенное наименование (код) элемента.</value>
        public string Block { get; set; }

        /// <summary>
        /// Квартира.
        /// </summary>
        /// <value><b>Кварт</b> - сокращенное наименование (код) элемента.</value>
        public string Apartment { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{nameof(RegionCode)}: {RegionCode}. {ZipCode}, {City}, {Street}, {Building} {Block}, {Apartment}";
    }
}