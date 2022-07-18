namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/16b342f62e586e98d5a0ca3b77fdb6cfb57fdf12/#dst101202">Контактные данные.</see>
    /// </summary>
    /// <value><b>Контакт</b> - сокращенное наименование (код) элемента.</value>
    public class Contact
    {
        /// <summary>
        /// Номер контактного телефона/факс.
        /// </summary>
        /// <value><b>Тлф</b> - сокращенное наименование (код) элемента.</value>
        public string Phone { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        /// <value><b>ЭлПочта</b> - сокращенное наименование (код) элемента.</value>
        public string Email { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"Phone: {Phone}. Email: {Email}";
    }
}
