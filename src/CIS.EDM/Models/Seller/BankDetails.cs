namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/1a87107a5d6812641a592678120e6042bfbb5c85/#dst101353">Сведения о банке.</see>
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
