namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/24e0f0b1b45c26f78a98a9d4a1ba23f76918ff80/#dst100955">Иное лицо.</see>
    /// </summary>
    /// <value><b>ИнЛицо</b> - сокращенное наименование (код) элемента.</value>
    public record OtherIssuer
    {
        /// <summary>
        /// Представитель организации, которой доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
        /// </summary>
        /// <value><b>ПредОргПер</b> - сокращенное наименование (код) элемента.</value>
        public TransferOrganizationPerson OrganizationPerson { get; set; }

        /// <summary>
        /// Физическое лицо, которому доверена отгрузка товаров (передача результатов работ), передача имущественных прав (предъявление оказанных услуг).
        /// </summary>
        /// <value><b>ФЛПер</b> - сокращенное наименование (код) элемента.</value>
        public TransferPhysicalPerson PhysicalPerson { get; set; }
    }
}
