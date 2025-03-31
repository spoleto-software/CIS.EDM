namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// Сведения о <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/a61ab3a041046ac3f673fe355466c9d6a068cd13/#dst102005">лице, принявшем товары (груз).</see>
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
