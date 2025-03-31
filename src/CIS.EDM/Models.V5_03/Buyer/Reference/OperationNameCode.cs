namespace CIS.EDM.Models.V5_03.Buyer.Reference
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Код, обозначающий итог приемки товара (работ, услуг, прав).</see>
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
