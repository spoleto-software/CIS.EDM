namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// Налоговая ставка.
    /// </summary>
    public enum TaxRate
    {
        /// <summary>
        /// "без НДС"
        /// </summary>
        WithoutVat,

        /// <summary>
        /// "0%"
        /// </summary>
        Zero,

        /// <summary>
        /// "10%"
        /// </summary>
        TenPercent,

        /// <summary>
        /// "18%"
        /// </summary>
        EighteenPercent,

        /// <summary>
        /// "20%"
        /// </summary>
        TwentyPercent,

        /// <summary>
        /// "10/110"
        /// </summary>
        TenFraction,

        /// <summary>
        /// "18/118"
        /// </summary>
        EighteenFraction,

        /// <summary>
        /// "20/120"
        /// </summary>
        TwentyFraction,

        /// <summary>
        /// "НДС исчисляется налоговым агентом"
        /// </summary>
        TaxedByAgent
    }
}