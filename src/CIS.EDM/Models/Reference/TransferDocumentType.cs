namespace CIS.EDM.Models.Reference
{
    /// <summary>
    /// Тип УПД.
    /// </summary>
    public enum TransferDocumentType
    {
        /// <summary>
        /// Общий случай
        /// </summary>
        Default = 0,

        /// <summary>
        /// Для товаров, подлежащих прослеживаемости.
        /// </summary>
        Proc = 1,

        /// <summary>
        /// Для товаров, подлежащих маркировке.
        /// </summary>
        Mark = 2
    }
}
