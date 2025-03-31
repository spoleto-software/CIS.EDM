namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Сведения о банке.</see>
	/// </summary>
	/// <value><b>СвБанк</b> - сокращенное наименование (код) элемента.</value>
	public record BankDetails
    {
        /// <summary>
        /// Наименование банка.
        /// </summary>
        /// <value><b>НаимБанк</b> - сокращенное наименование (код) элемента.</value>
        public string BankName { get; set; }

        /// <summary>
        /// Банковский идентификационный код (БИК) в соответствии со "Справочником БИК РФ".
        /// </summary>
        /// <value><b>БИК</b> - сокращенное наименование (код) элемента.</value>
        public string BankId { get; set; }

        /// <summary>
        /// Корреспондентский счет банка
        /// </summary>
        /// <value><b>КорСчет</b> - сокращенное наименование (код) элемента.</value>
        public string CorrespondentAccount { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => BankName;
    }
}
