namespace CIS.EDM.Models.V5_01.Buyer.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/87d4700fa0bed4fa2cdc53a5b6d8d00338147665/#dst101964">Код, обозначающий итог приемки товара (работ, услуг, прав).</see>
    /// </summary>
    public enum OperationNameCode
    {
        /// <summary>
        /// Товары (работы, услуги, права) приняты без расхождений (претензий).
        /// </summary>
        /// <value>1</value>
        Accepted = 1,

        /// <summary>
        /// Товары (работы, услуги, права) приняты с расхождениями (претензией).
        /// </summary>
        /// <value>2</value>
        AcceptedWithDiscrepancies = 2,

        /// <summary>
        /// Товары (работы, услуги, права) не приняты.
        /// </summary>
        /// <value>3</value>
        NotAccepted = 3
    }
}
