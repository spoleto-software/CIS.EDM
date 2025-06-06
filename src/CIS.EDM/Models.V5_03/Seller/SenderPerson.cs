namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Сведения о лице, передавшем товар (имущество) (СвЛицПер).
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
