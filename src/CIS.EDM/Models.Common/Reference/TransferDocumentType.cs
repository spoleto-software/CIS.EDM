namespace CIS.EDM.Models.Common.Reference
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
        Mark = 2,

		/// <summary>
		/// Для алкогольной продукции, подлежащей маркировке.
		/// </summary>
		Beer = 3,

		/// <summary>
		/// Для табачной продукции, сырья, никотинсодержащей продукции и никотинового сырья.
		/// </summary>
		Tobacco = 4,

		/// <summary>
		/// Для нефтепродуктов.
		/// </summary>
		Oil
	}
}
