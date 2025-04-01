namespace CIS.EDM.Models.Reference
{
    /// <summary>
    /// Справочник "Статусы документов
    /// </summary>
    public enum DocumentState
    {
        /// <summary>
        /// Черновик
        /// </summary>
        Draft = 0,

        /// <summary>
        /// Ожидается отправка
        /// </summary>
        AwaitingSending = 11,

        /// <summary>
        /// Отправлен
        /// </summary>
        Sent = 1,

        /// <summary>
        /// Доставлен (подпись не требуется) Подпись не требуется
        /// </summary>
        DeliveredNoSignatureRequired = 2,

        /// <summary>
        /// Просмотрен (подпись не требуется) Подпись не требуется (документ просмотрен)
        /// </summary>
        ReviewedNoSignatureRequired = 12,

        /// <summary>
        /// Доставлен (ожидается подпись) Требуется подпись
        /// </summary>
        DeliveredSignatureRequired = 3,

        /// <summary>
        /// Просмотрен (ожидается подпись) Требуется подпись (документ просмотрен)
        /// </summary>
        ReviewedSignatureRequired = 13,

        /// <summary>
        /// Подписан
        /// </summary>
        Signed = 4,

        /// <summary>
        /// Подписан: Отправлен в ГИС МТ
        /// </summary>
        SignedSentToGisMT = 61,

        /// <summary>
        /// Отклонен
        /// </summary>
        Declined = 5,

        /// <summary>
        /// Отклонен (запрос просмотрен)
        /// </summary>
        DeclinedRequestReviewed = 15,

        /// <summary>
        /// Уточнён
        /// </summary>
        Clarified = 7,

        /// <summary>
        /// Требуется уточнение Ожидается уточнение
        /// </summary>
        ClarificationRequired = 8,

        /// <summary>
        /// Требуется уточнение (запрос на уточнение просмотрен)
        /// Запрос на уточнение просмотрен (ожидается уточнение)
        /// </summary>
        ClarificationRequiredClarificationRequestReviewed = 14,

        /// <summary>
        /// Ошибка в подписи
        /// </summary>
        SignatureError = 9,

        /// <summary>
        /// Ошибка доставки
        /// </summary>
        DeliveryError = 10
    }
}
