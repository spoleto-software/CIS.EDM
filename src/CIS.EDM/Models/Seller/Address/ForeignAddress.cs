using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Seller.Address
{
    /// <summary>
    /// Адрес, указанный в Едином государственном реестре юридических лиц/почтовый адрес/адрес места жительства индивидуального предпринимателя (информация об адресе, в том числе об адресе за пределами территории Российской Федерации).
    /// </summary>
    /// <value><b>АдрИнф</b> - сокращенное наименование (код) элемента.</value>
    public class ForeignAddress
    {
        /// <summary>
        /// Код страны.
        /// </summary>
        /// <remarks>
        /// Принимает значение в соответствии с Общероссийским классификатором стран мира.
        /// </remarks>
        /// <value><b>КодСтр</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string CountryCode { get; set; }

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