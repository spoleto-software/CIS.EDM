namespace CIS.EDM.Models
{
    /// <summary>
    /// Справочник "Типы документов"
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// Уведомление об уточнении (DP_UVUTOCH)
        /// </summary>
        ClarificationNotice = 110,

        /// <summary>
        /// Квитанция подтверждения даты получения (DP_PDPOL)
        /// </summary>
        ConfirmationOfReceiptDate = 111,

        /// <summary>
        /// Квитанция подтверждения даты отправки (DP_PDOTPR)
        /// </summary>
        ConfirmationOfShipmentDate = 112,

        /// <summary>
        /// Квитанция извещение о получении файла продавцом (DP_IZVPOL)
        /// </summary>
        NotificationOfReceiptOfFileBySeller = 113,

        /// <summary>
        /// Квитанция предложения об аннулировании документа (DP_PRANNUL)
        /// </summary>
        ProposalForCancellationOfDocument = 114,

        /// <summary>
        /// Квитанция извещение о получении файла покупателем (DP_IZVPOL)
        /// </summary>
        NotificationOfReceiptOfFileBybuyer = 115,

        /// <summary>
        /// УКД с функцией ДИС (корректировка накладной)
        /// </summary>
        UKDWithDISWaybillCorrection = 200,

        /// <summary>
        /// УКД с функцией ДИС информация покупателя (корректировка накладной)
        /// </summary>
        UKDWithDISBuyerInformationWaybillCorrection = 201,

        /// <summary>
        /// УКД с функцией КСЧФ (корректировка счет-фактуры)
        /// </summary>
        UKDWithKSCHFInvoiceCorrection = 202,

        /// <summary>
        /// УКД с функцией КСЧФДИС (корректировка счет-фактуры+накладная)
        /// </summary>
        UKDWithKSCHFInvoiceWaybillCorrection = 204,

        /// <summary>
        /// УКД с функцией КСЧФДИС информация покупателя (корректировка счет-фактуры+накладная)
        /// </summary>
        UKDWithKSCHFBuyerInformationInvoiceWaybillCorrection = 205,

        /// <summary>
        /// УПД с функцией ДОП (Накладная)
        /// </summary>
        UPDWithDOPInvoice = 500,

        /// <summary>
        /// УПД с функцией ДОП информация покупателя (Накладная)
        /// </summary>
        UPDWithDOPBuyerInformationInvoice = 501,

        /// <summary>
        /// УПД с функцией СЧФДОП (Счёт-фактура+Накладная)
        /// </summary>
        UPDWithSCHFDOPInvoiceWaybill = 504,

        /// <summary>
        /// УПД с функцией СЧФДОП информация покупателя (Счёт-фактура+Накладная)
        /// </summary>
        UPDWithSCHFDOPBuyerInformationInvoiceWaybill = 505,

        /// <summary>
        /// УПД(и) с функцией ДОП (Накладная исправленная)
        /// </summary>
        UPDiWithDOPInvoiceCorrected = 800,

        /// <summary>
        /// УПД(и) с функцией ДОП информация покупателя (Накладная исправленная)
        /// </summary>
        UPDiWithDOPBuyerInformationInvoiceCorrected = 801,

        /// <summary>
        /// УПД(и) с функцией СЧФДОП (Счёт-фактура исправленный + Накладная)
        /// </summary>
        UPDiWithSCHFDOPInvoicCorrectedeWaybill = 804,

        /// <summary>
        /// УПД(и) с функцией СЧФДОП информация покупателя (Счёт-фактура исправленный + Накладная)
        /// </summary>
        UPDiWithSCHFDOPBuyerInformationInvoicCorrectedeWaybill = 805
    }
}
