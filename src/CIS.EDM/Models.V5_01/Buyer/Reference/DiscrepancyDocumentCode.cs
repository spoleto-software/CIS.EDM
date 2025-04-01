namespace CIS.EDM.Models.V5_01.Buyer.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/87d4700fa0bed4fa2cdc53a5b6d8d00338147665/#dst101964">Код вида документа о расхождениях.</see>
    /// </summary>
    public enum DiscrepancyDocumentCode
    {
        /// <summary>
        /// Неопределено.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// Документ о приемке с расхождениями.
        /// </summary>
        AcceptanceDocumentWithDiscrepancies = 2,

        /// <summary>
        /// Документ о расхождениях.
        /// </summary>
        DiscrepancyDocument = 3
    }
}
