using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/cc4c28a5922401157913a02536bcc53c69c49cc3/#dst102378">Сведения об индивидуальном предпринимателе.</see>
    /// </summary>
    /// <value><b>ИП</b> - сокращенное наименование (код) элемента.</value>
    public class IndividualEntrepreneur : SignerPersonBase
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
