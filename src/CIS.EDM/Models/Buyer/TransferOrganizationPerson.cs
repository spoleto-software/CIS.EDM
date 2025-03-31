using CIS.EDM.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/2961bcbfcb42d9ee46b8ce9748c3deaac6d21e33/#dst102070">Представитель организации</see>, которой доверено принятие товаров (груза).
    /// </summary>
    /// <value><b>ПредОргПрин</b> - сокращенное наименование (код) элемента.</value>
    public record TransferOrganizationPerson : Person
    {
        /// <summary>
        /// Должность
        /// </summary>
        /// <value><b>Должность</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string JobTitle { get; set; }

        /// <summary>
        /// Иные сведения, идентифицирующие физическое лицо.
        /// </summary>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string EmployeeInfo { get; set; }

        /// <summary>
        /// Наименование организации.
        /// </summary>
        /// <value><b>НаимОргПер</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Основание, по которому организации доверено принятие товаров (груза).
        /// </summary>
        /// <value><b>ОснДоверОргПрин</b> - сокращенное наименование (код) элемента.</value>
        public string OrganizationBase { get; set; }

        /// <summary>
        /// Основание полномочий представителя организации на принятие товаров (груза).
        /// </summary>
        /// <value><b>ОснПолнПредПрин</b> - сокращенное наименование (код) элемента.</value>
        public string EmployeeBase { get; set; } = "Должностные обязанности";
    }
}
