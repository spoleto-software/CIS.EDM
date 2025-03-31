namespace CIS.EDM.Models.V5_03.Buyer.Reference
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Вид платежа.</see>
	/// </summary>
	public enum PaymentType
    {
        /// <summary>
        /// Неопределено.
        /// </summary>
        NotSpecified = -1,

        /// <summary>
        /// Пусто.
        /// </summary>
        Empty = 0,

        /// <summary>
        /// Срочно.
        /// </summary>
        Urgent = 4
    }
}
