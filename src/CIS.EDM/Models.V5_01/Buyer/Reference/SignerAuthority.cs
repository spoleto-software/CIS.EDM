namespace CIS.EDM.Models.V5_01.Buyer.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/08f8bb6016cbc4090c0016e6698417127ea24046/#dst102297">Область полномочий.</see>
    /// </summary>
    /// <value><b>ОблПолн</b> - сокращенное наименование (код) элемента.</value>
    public enum SignerAuthority
    {
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
        PersonDocumentedOperation = 3
    }
}
