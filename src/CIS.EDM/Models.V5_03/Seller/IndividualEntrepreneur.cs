using CIS.EDM.Models.Common;

namespace CIS.EDM.Models.V5_03.Seller
{
    /// <summary>
    /// Сведения об индивидуальном предпринимателе.
    /// </summary>
    /// <value><b>ИП</b> - сокращенное наименование (код) элемента.</value>
    public record IndividualEntrepreneur : Person
    {
        /// <summary>
        /// ИНН
        /// </summary>
        /// <value><b>ИННФЛ</b> - сокращенное наименование (код) элемента.</value>
        public string Inn { get; set; }

        /// <summary>
        /// Реквизиты свидетельства о государственной регистрации индивидуального предпринимателя.
        /// </summary>
        /// <remarks>
        /// Обязателен для случаев подписания счета-фактуры непосредственно продавцом.
        /// </remarks>
        /// <value><b>СвГосРегИП</b> - сокращенное наименование (код) элемента.</value>
        public string IndividualEntrepreneurRegistrationCertificate { get; set; }

        /// <summary>
        /// Иные сведения, идентифицирующие физическое лицо.
        /// </summary>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string OtherInfo { get; set; }
    }
}
