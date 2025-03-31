using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Common
{
    /// <summary>
    /// Физическое лицо (либо ИП).
    /// </summary>
    /// <value><b>ФИО</b> - сокращенное наименование (код) элемента.</value>
    public record Person
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        /// <value><b>Фамилия</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        /// <value><b>Имя</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        /// <value><b>Отчество</b> - сокращенное наименование (код) элемента.</value>
        public string Patronymic { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Surname} {FirstName} {Patronymic}";
    }
}
