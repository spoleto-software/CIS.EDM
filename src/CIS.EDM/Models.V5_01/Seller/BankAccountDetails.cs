namespace CIS.EDM.Models.V5_01.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/b73b0fb74198192dd076225c5b48ea9626dae23a/#dst101335">Банковские реквизиты.</see>
    /// </summary>
    /// <value><b>БанкРекв</b> - сокращенное наименование (код) элемента.</value>
    public record BankAccountDetails
    {
        /// <summary>
        /// Номер банковского счета.
        /// </summary>
        /// <value><b>НомерСчета</b> - сокращенное наименование (код) элемента.</value>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Сведения о банке.
        /// </summary>
        /// <value><b>СвБанк</b> - сокращенное наименование (код) элемента.</value>
        public BankDetails BankDetails { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{BankAccountNumber}, {BankDetails}";
    }
}
