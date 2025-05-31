using CIS.EDM.Models.V5_03.Seller.Address;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Сведения об участнике факта хозяйственной жизни.
	/// </summary>
	public record Organization
	{
		/// <summary>
		/// Код в общероссийском классификаторе предприятий и организаций.
		/// </summary>
		/// <value><b>ОКПО</b> - сокращенное наименование (код) элемента.</value>
		public string Okpo { get; set; }

		/// <summary>
		/// Код по Общероссийскому классификатору организационно-правовых форм об организационно-правовой форме
		/// </summary>
		/// <value><b>КодОПФ</b> - сокращенное наименование (код) элемента.</value>
		public string Opf { get; set; }

		/// <summary>
		/// Полное наименование организационно-правовой формы.
		/// </summary>
		/// <value><b>ПолнНаимОПФ</b> - сокращенное наименование (код) элемента.</value>
		public string FullName { get; set; }

		/// <summary>
		/// Структурное подразделение.
		/// </summary>
		/// <value><b>СтруктПодр</b> - сокращенное наименование (код) элемента.</value>
		public string Department { get; set; }

		/// <summary>
		/// Информация для участника документооборота.
		/// </summary>
		/// <value><b>ИнфДляУчаст</b> - сокращенное наименование (код) элемента.</value>
		public string OrganizationAdditionalInfo { get; set; }

		/// <summary>
		/// Краткое название.
		/// </summary>
		/// <value><b>КраткНазв</b> - сокращенное наименование (код) элемента.</value>
		public string ShortName { get; set; }

		/// <summary>
		/// Идентификационные сведения.
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
		///         <description>Сведения об иностранном лице, не состоящем на учете в налоговых органах в качестве налогоплательщика.</description>
		///     </item>
		///     <item>
		///         <term><see cref="PhysicalPerson"/></term>
		///         <description>Сведения о физическом лице.</description>
		///     </item>   
		/// </list>
		/// </remarks>
		/// <value><b>ИдСв</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public OrganizationIdentificationInfo OrganizationIdentificationInfo { get; set; }

		/// <summary>
		/// Адрес
		/// </summary>
		/// <remarks>
		/// Заполняется один из видов адреса:
		/// <list type="table">
		///     <item>
		///     <term><see cref="RussianAddress"/></term>
		///     <description>адрес РФ</description>
		///     </item>
		///     <item>
		///         <term><see cref="AddressInformation"/></term>
		///         <description>адрес за пределами РФ</description>
		///     </item>
		///     <item>
		///         <term><see cref="AddressCode"/></term>
		///         <description>уникальный номер адреса объекта адресации в государственном адресном реестре.</description>
		///     </item>    
		/// </list>
		/// </remarks>
		/// <value><b>Адрес</b> - сокращенное наименование (код) элемента.</value>
		public Address.Address Address { get; set; }

		/// <summary>
		/// Банковские реквизиты
		/// </summary>
		/// <value><b>БанкРекв</b> - сокращенное наименование (код) элемента.</value>
		public BankAccountDetails BankAccountDetails { get; set; }

		/// <summary>
		/// Контактные данные.
		/// </summary>
		/// <value><b>Контакт</b> - сокращенное наименование (код) элемента.</value>
		public Contact Contact { get; set; }

		/// <summary>
		/// Текстовое представление объекта.
		/// </summary>
		public override string ToString() => ShortName;
	}
}