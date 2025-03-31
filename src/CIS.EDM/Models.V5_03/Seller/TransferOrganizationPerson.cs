using CIS.EDM.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Представитель организации</see>, которой доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
	/// </summary>
	/// <value><b>ПредОргПер</b> - сокращенное наименование (код) элемента.</value>
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
        /// Основание, по которому организации доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
        /// </summary>
        /// <value><b>ОснДоверОргПер</b> - сокращенное наименование (код) элемента.</value>
        public string OrganizationBase { get; set; }

        /// <summary>
        /// Основание полномочий представителя организации на отгрузку товаров (передачу результатов работ), передачу имущественных прав (предъявление оказанных услуг).
        /// </summary>
        /// <value><b>ОснПолнПредПер</b> - сокращенное наименование (код) элемента.</value>
        public string EmployeeBase { get; set; } = "Должностные обязанности";
    }
}
