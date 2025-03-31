using CIS.EDM.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Представитель юридического лица.</see>
	/// </summary>
	/// <value><b>ЮЛ</b> - сокращенное наименование (код) элемента.</value>
	public record LegalPersonRepresentative : Person
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
