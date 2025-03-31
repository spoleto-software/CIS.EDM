namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Сведения о <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">лице, передавшем товар (груз).</see>
	/// </summary>
	/// <value><b>СвЛицПер</b> - сокращенное наименование (код) элемента.</value>
	public record SenderPerson
    {
        /// <summary>
        /// Работник организации продавца.
        /// </summary>
        /// <value><b>РабОргПрод</b> - сокращенное наименование (код) элемента.</value>
        public SenderEmployee Employee { get; set; }

        /// <summary>
        /// Иное лицо.
        /// </summary>
        /// <value><b>ИнЛицо</b> - сокращенное наименование (код) элемента.</value>
        public OtherIssuer OtherIssuer { get; set; }
    }
}
