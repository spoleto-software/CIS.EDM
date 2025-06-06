namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Иное лицо.</see>
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
