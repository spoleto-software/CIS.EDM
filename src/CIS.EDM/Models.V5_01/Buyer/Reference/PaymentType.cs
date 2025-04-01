namespace CIS.EDM.Models.V5_01.Buyer.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/04e48676e207e52fa7f21290c571150f67a2cd4a/#dst102169">Вид платежа.</see>
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
