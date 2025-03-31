using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Сведения об индивидуальном предпринимателе.</see>
	/// </summary>
	/// <value><b>ИП</b> - сокращенное наименование (код) элемента.</value>
	public record IndividualEntrepreneur : SignerPersonBase
    {
        /// <summary>
        /// ИНН
        /// </summary>
        /// <value><b>ИННФЛ</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Inn { get; set; }

        /// <summary>
        /// Реквизиты свидетельства о государственной регистрации индивидуального предпринимателя.
        /// </summary>
        /// <remarks>
        /// Обязателен для случаев подписания счета-фактуры непосредственно продавцом.
        /// </remarks>
        /// <value><b>СвГосРегИП</b> - сокращенное наименование (код) элемента.</value>
        public string IndividualEntrepreneurRegistrationCertificate { get; set; }
    }
}
