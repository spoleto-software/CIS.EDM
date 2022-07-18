using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/37c446604d0f3a276038c77ca4f0a88778de30ac/#dst101162">Представитель юридического лица.</see>
    /// </summary>
    /// <value><b>ЮЛ</b> - сокращенное наименование (код) элемента.</value>
    public class LegalPersonRepresentative : Person
    {
        /// <summary>
        /// Реквизиты свидетельства о государственной регистрации индивидуального предпринимателя,
        /// выдавшего доверенность организации на подписание счета-фактуры.
        /// </summary>
        /// <remarks>
        /// Обязателен для подписанта счета-фактуры в случае выставления счета-фактуры индивидуальным предпринимателем,
        /// когда счет-фактура подписывается работником организации, уполномоченной доверенностью от имени индивидуального предпринимателя.
        /// </remarks>
        /// <value><b>ГосРегИПВыдДов</b> - сокращенное наименование (код) элемента.</value>
        public string IndividualEntrepreneurRegistrationCertificate { get; set; }

        /// <summary>
        /// ИНН юридического лица.
        /// </summary>
        /// <value><b>ИННЮЛ</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Inn { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        /// <value><b>НаимОрг</b> - сокращенное наименование (код) элемента.</value>
        public string OrgName { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        /// <value><b>Должн</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string JobTitle { get; set; }

        /// <summary>
        /// Иные сведения, идентифицирующие физическое лицо.
        /// </summary>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string OtherInfo { get; set; }
    }
}
