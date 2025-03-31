namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Иное лицо.</see>
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
