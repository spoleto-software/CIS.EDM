namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/aaef3355d839b3243c27a813bbd5433411bd0335/#dst102407">Сведения о физическом лице.</see>
    /// </summary>
    /// <value><b>ФЛ</b> - сокращенное наименование (код) элемента.</value>
    public class PhysicalPerson : SignerPersonBase
    {
        /// <summary>
        /// ИНН физического лица.
        /// </summary>
        /// <remarks>
        /// Обязателен для подписанта при наличии в сертификате ключа проверки электронной подписи.
        /// </remarks>
        /// <value><b>ИННФЛ</b> - сокращенное наименование (код) элемента.</value>
        public string Inn { get; set; }
    }
}
