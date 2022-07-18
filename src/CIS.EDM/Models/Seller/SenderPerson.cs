namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// Сведения о <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/25d4e09cf32a60de9d4363a129d84d982f79984a/#dst100908">лице, передавшем товар (груз).</see>
    /// </summary>
    /// <value><b>СвЛицПер</b> - сокращенное наименование (код) элемента.</value>
    public class SenderPerson
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
