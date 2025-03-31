namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Контактные данные.</see>
	/// </summary>
	/// <value><b>Контакт</b> - сокращенное наименование (код) элемента.</value>
	public record Contact
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
