using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_01.Seller
{
    /// <summary>
    /// Базовый класс для документов.
    /// </summary>
    public record DocumentBase
    {
        /// <summary>
        /// Наименование документа-основания
        /// </summary>
        /// <value><b>НаимОсн</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string DocumentName { get; set; } = "Без документа-основания";

        /// <summary>
        /// Номер документа-основания
        /// </summary>
        /// <value><b>НомОсн</b> - сокращенное наименование (код) элемента.</value>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Дата документа - основания
        /// </summary>
        /// <remarks>
        /// Обязателен при <see cref="DocumentName"/> отличном от значения "Отсутствует"
        /// </remarks>
        /// <value><b>ДатаОсн</b> - сокращенное наименование (код) элемента.</value>
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// Дополнительные сведения
        /// </summary>
        /// <value><b>ДопСвОсн</b> - сокращенное наименование (код) элемента.</value>
        public string DocumentInfo { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{DocumentName} №<{DocumentNumber}> от <{DocumentDate}>.";
    }
}