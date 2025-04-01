using CIS.EDM.Models;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03
{
    /// <summary>
    /// Сотрудник организации.
    /// </summary>
    public record Employee : Person
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
    }
}
