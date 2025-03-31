namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// Сведения о <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">лице, принявшем товары (груз).</see>
	/// </summary>
	/// <value><b>СвЛицПрин</b> - сокращенное наименование (код) элемента.</value>
	public record ReceiverPerson
    {
        /// <summary>
        /// Работник организации покупателя.
        /// </summary>
        /// <value><b>РабОргПок</b> - сокращенное наименование (код) элемента.</value>
        public ReceiverEmployee Employee { get; set; }

        /// <summary>
        /// Иное лицо.
        /// </summary>
        /// <value><b>ИнЛицо</b> - сокращенное наименование (код) элемента.</value>
        public OtherIssuer OtherIssuer { get; set; }
    }
}
