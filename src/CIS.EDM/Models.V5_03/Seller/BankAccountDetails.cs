namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Банковские реквизиты.</see>
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
