namespace CIS.EDM.Models.V5_01.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/68cba90672e535ea25e08113b82db5bcdd6d5806/#dst102052">Иное лицо.</see>
    /// </summary>
    /// <value><b>ИнЛицо</b> - сокращенное наименование (код) элемента.</value>
    public record OtherIssuer
    {
        /// <summary>
        /// Представитель организации, которой доверено принятие товаров (груза).
        /// </summary>
        /// <value><b>ПредОргПрин</b> - сокращенное наименование (код) элемента.</value>
        public TransferOrganizationPerson OrganizationPerson { get; set; }

        /// <summary>
        /// Физическое лицо, которому доверено принятие товаров (груза).
        /// </summary>
        /// <value><b>ФЛПрин</b> - сокращенное наименование (код) элемента.</value>
        public TransferPhysicalPerson PhysicalPerson { get; set; }
    }
}
