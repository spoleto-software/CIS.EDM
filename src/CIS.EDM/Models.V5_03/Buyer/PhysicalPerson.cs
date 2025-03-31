namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Сведения о физическом лице.</see>
	/// </summary>
	/// <value><b>ФЛ</b> - сокращенное наименование (код) элемента.</value>
	public record PhysicalPerson : SignerPersonBase
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
