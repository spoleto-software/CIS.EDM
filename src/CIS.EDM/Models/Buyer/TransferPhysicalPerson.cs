using CIS.EDM.Models.Common;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/f05d3ae778aa5d20effde683aca86df2d6d879d9/#dst102109">Физическое лицо</see>, которому доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
    /// </summary>
    /// <value><b>ФЛПер</b> - сокращенное наименование (код) элемента.</value>
    public record TransferPhysicalPerson : Person
    {
        /// <summary>
        /// Иные сведения, идентифицирующие физическое лицо.
        /// </summary>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string PersonInfo { get; set; }

        /// <summary>
        /// Основание, по которому физическому лицу доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
        /// </summary>
        /// <value><b>ОснДоверФЛ</b> - сокращенное наименование (код) элемента.</value>
        public string PersonBase { get; set; }
    }
}
