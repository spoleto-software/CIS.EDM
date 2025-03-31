namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Идентификационные сведения участника факта хозяйственной жизни.
	/// </summary>
	/// <remarks>
	/// Заполняется один из видов сведений:
	/// <list type="table">
	///     <item>
	///     <term><see cref="IndividualEntrepreneur"/></term>
	///     <description>Сведения об индивидуальном предпринимателе</description>
	///     </item>
	///     <item>
	///         <term><see cref="LegalPerson"/></term>
	///         <description>Сведения о юридическом лице, состоящем на учете в налоговых органах</description>
	///     </item>
	///     <item>
	///         <term><see cref="ForeignPerson"/></term>
	///         <description>Сведения об иностранной организации (иностранном гражданине), не состоящей на учете в налоговых органах.</description>
	///     </item>
	///     <item>
	///         <term><see cref="PhysicalPerson"/></term>
	///         <description>Сведения о физическом лице.</description>
	///     </item>   
	/// </list>
	/// </remarks>
	/// <value><b>ИдСв</b> - сокращенное наименование (код) элемента.</value>
	public record OrganizationIdentificationInfo
    {
        /// <summary>
        /// Сведения об индивидуальном предпринимателе.
        /// </summary>
        /// <value><b>СвИП</b> - сокращенное наименование (код) элемента.</value>
        public IndividualEntrepreneur IndividualEntrepreneur { get; set; }

		/// <summary>
		/// Сведения о юридическом лице, состоящем на учете в налоговых органах.
		/// </summary>
		/// <value><b>СвЮЛУч</b> - сокращенное наименование (код) элемента.</value>
		public LegalPerson LegalPerson { get; set; }

		/// <summary>
		/// Сведения об иностранном лице, не состоящем на учете в налоговых органах в качестве налогоплательщика.
		/// </summary>
		/// <value><b>СвИнНеУч</b> - сокращенное наименование (код) элемента.</value>
		public ForeignPerson ForeignPerson { get; set; }

		/// <summary>
		/// Сведения о физическом лице.
		/// </summary>
		/// <remarks>
		/// Для документов с Функция = ДОП
		/// </remarks>
		/// <value><b>СвФЛУч</b> - сокращенное наименование (код) элемента.</value>
		public PhysicalPerson PhysicalPerson { get; set; }
    }
}