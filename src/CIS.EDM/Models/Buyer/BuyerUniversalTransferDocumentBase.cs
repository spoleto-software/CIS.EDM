using CIS.EDM.Models.Reference;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Buyer
{
	/// <summary>
	/// Информация покупателя УПД согласно.
	/// </summary>
	/// <value><b>Файл</b> - сокращенное наименование (код) элемента.</value>
	public abstract record BuyerUniversalTransferDocumentBase : UniversalTransferDocumentBase
	{
		/// <summary>
		/// Тип участника.
		/// </summary>
		public sealed override PartyType PartyType => PartyType.Buyer;

		/// <summary>
		/// Идентификатор электронного документа продавца (не файла).
		/// </summary>
		/// <remarks>
		/// Используется для поиска неподписанного документа в электронном ящике и заполнения свойства <see cref="SellerDocumentInfo"/>.
		/// </remarks>
		public string EdmDocumentId { get; set; }

		/// <summary>
		/// Код документа по КНД
		/// </summary>
		/// <remarks>
		/// Принимает значение: 1115132.
		/// </remarks>
		/// <value><b>КНД</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string TaxDocumentCode { get; set; } = "1115132";

		/// <summary>
		/// Идентификация файла обмена счета-фактуры (информации продавца) или файла обмена информации продавца
		/// </summary>
		/// <remarks>
		/// Если не передать, то для ЦРПТ провайдера заполнится автоматом на основе <see cref="EdmDocumentId"/>.
		/// </remarks>
		/// <value><b>ИдИнфПрод</b> - сокращенное наименование (код) элемента.</value>
		public SellerDocumentInfo SellerDocumentInfo { get; set; }

		/// <summary>
		/// Вид операции.
		/// </summary>
		/// <remarks>
		/// Дополнительная информация, позволяющая в автоматизированном режиме определять необходимый для конкретного случая
		/// порядок использования информации документа у покупателя.
		/// </remarks>
		/// <value><b>ВидОперации</b> - сокращенное наименование (код) элемента.</value>
		public string OperationType { get; set; }
	}
}
