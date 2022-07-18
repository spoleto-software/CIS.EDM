namespace CIS.EDM.Models.Seller.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/bd7db2cf0a46edbc4ca62eea69fd164893370301/">Область полномочий.</see>
    /// </summary>
    /// <value><b>ОблПолн</b> - сокращенное наименование (код) элемента.</value>
    public enum SignerAuthority
    {
        /// <summary>
        /// Лицо, ответственное за подписание счетов-фактур.
        /// </summary>
        /// <value>0</value>
        PersonResponsibleForSigningInvoice = 0,

        /// <summary>
        /// Лицо, совершившее сделку, операцию.
        /// </summary>
        /// <value>1</value>
        PersonMadeOperation = 1,

        /// <summary>
        /// Лицо, совершившее сделку, операцию и ответственное за ее оформление.
        /// </summary>
        /// <value>2</value>
        PersonMadeAndResponsibleForOperation = 2,

        /// <summary>
        /// Лицо, ответственное за оформление свершившегося события.
        /// </summary>
        /// <value>3</value>
        PersonDocumentedOperation = 3,

        /// <summary>
        /// Лицо, совершившее сделку, операцию и ответственное за подписание счетов-фактур.
        /// </summary>
        /// <value>4</value>
        PersonMadeOperationAndResponsibleForSigningInvoice = 4,

        /// <summary>
        /// Лицо, совершившее сделку, операцию и ответственное за ее оформление и за подписание счетов-фактур.
        /// </summary>
        /// <value>5</value>
        PersonMadeAndResponsibleForOperationAndSigningInvoice = 5,

        /// <summary>
        /// Лицо, ответственное за оформление свершившегося события и за подписание счетов-фактур.
        /// </summary>
        /// <value>6</value>
        PersonResponsibleForOperationAndSigningInvoice = 6
    }
}
