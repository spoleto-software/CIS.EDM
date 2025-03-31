namespace CIS.EDM.Models.V5_03.Seller.Reference
{
	/// <summary>
	/// Признак <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">товара</see>.
	/// </summary>
	public enum InvoiceItemType
    {
        /// <summary>
        /// неопределено
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// имущество
        /// </summary>
        Property = 1,

        /// <summary>
        /// работа
        /// </summary>
        Job = 2,

        /// <summary>
        /// услуга 
        /// </summary>
        Servic = 3,

        /// <summary>
        /// имущественные права
        /// </summary>
        PropertyRights = 4,

        /// <summary>
        /// иное
        /// </summary>
        Other = 5
    }
}
