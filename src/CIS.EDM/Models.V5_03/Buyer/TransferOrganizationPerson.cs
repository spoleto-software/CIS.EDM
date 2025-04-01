using CIS.EDM.Models;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Представитель организации</see>, которой доверено принятие товаров (груза).
	/// </summary>
	/// <value><b>ПредОргПрин</b> - сокращенное наименование (код) элемента.</value>
	public record TransferOrganizationPerson : Person
	{
		/// <summary>
		/// Должность
		/// </summary>
		/// <value><b>Должность</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string JobTitle { get; set; }

		/// <summary>
		/// Иные сведения, идентифицирующие физическое лицо.
		/// </summary>
		/// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
		public string EmployeeInfo { get; set; }

		/// <summary>
		/// Наименование организации.
		/// </summary>
		/// <value><b>НаимОргПер</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string OrganizationName { get; set; }

		/// <summary>
		/// ИНН юридического лица, которому доверен прием
		/// </summary>
		/// <value><b>ИННОргПрин</b> - сокращенное наименование (код) элемента.</value>
		public string OrganizationInn { get; set; }

		/// <summary>
		/// Основание, по которому организации доверено принятие товаров (груза).
		/// </summary>
		/// <value><b>ОснДоверОргПрин</b> - сокращенное наименование (код) элемента.</value>
		public Document OrganizationBase { get; set; }

		/// <summary>
		/// Основание полномочий представителя организации на принятие товаров (груза).
		/// </summary>
		/// <value><b>ОснПолнПредПрин</b> - сокращенное наименование (код) элемента.</value>
		public Document EmployeeBase { get; set; }
	}
}
