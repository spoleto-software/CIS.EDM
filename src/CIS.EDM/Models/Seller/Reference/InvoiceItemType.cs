namespace CIS.EDM.Models.Seller.Reference
{
    /// <summary>
    /// Признак <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/2fceb17c7e6af54052d079494238454102f38a65/#dst100652">товара</see>.
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
