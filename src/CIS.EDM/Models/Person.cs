using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/9081f38f12fc37cca69db97124ff9f5d8dc9a0b2/#dst101656">Физическое лицо (либо ИП).</see>
    /// </summary>
    /// <value><b>ФИО</b> - сокращенное наименование (код) элемента.</value>
    public class Person
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
