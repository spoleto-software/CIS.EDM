using CIS.EDM.Models.V5_03.Seller.Reference;
using System.Collections.Generic;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Дополнительные сведения об участниках факта хозяйственной жизни, основаниях и обстоятельствах его проведения (ДопСвФХЖ1)
	/// </summary>
	public record AdditionalTransactionParticipantInfo
	{
		/// <summary>
		/// Идентификатор государственного контракта, договора (соглашения) (строка 8 счета-фактуры). ИдГосКон.
		/// </summary>
		/// <remarks>
		/// Обязателен при наличии государственного контракта на поставку товаров (выполнение работ, оказание услуг),
		/// договора (соглашения) о предоставлении из федерального бюджета юридическому лицу субсидий,
		/// бюджетных инвестиций, взносов в уставный капитал.
		/// </remarks>
		/// <value><b>ИдГосКон</b> - сокращенное наименование (код) элемента.</value>
		public string GovernmentContractInfo { get; set; }

		/// <summary>
		/// Специальные обстоятельства формирования счета-фактуры, применяемого при расчетах по налогу на добавленную стоимость
		/// </summary>
		/// <value><b>ОбстФормСЧФ</b> - сокращенное наименование (код) элемента.</value>
		public InvoiceFormationType InvoiceFormationType { get; set; }

		/// <summary>
		/// Специальные обстоятельства формирования универсального передаточного документа, включающего счет-фактуру
		/// </summary>
		/// <value><b>СпОбстФСЧФДОП</b> - сокращенное наименование (код) элемента.</value>
		public string UPDInvoiceFormationType { get; set; }

		/// <summary>
		/// Специальные обстоятельства формирования документа
		/// </summary>
		/// <value><b>СпОбстФДОП</b> - сокращенное наименование (код) элемента.</value>
		public string UPDFormationType { get; set; }

		/// <summary>
		/// Вид обязательств
		/// </summary>
		/// <value><b>ВидОбяз</b> - сокращенное наименование (код) элемента.</value>
		public List<ObligationInfo> ObligationInfoList { get; set; }

		/// <summary>
		/// Информация продавца об обстоятельствах закупок для государственных и муниципальных нужд
		/// (для учета Федеральным казначейством денежных обязательств)
		/// </summary>
		/// <value><b>ИнфПродГосЗакКазн</b> - сокращенное наименование (код) элемента.</value>
		public SellerInfoCircumPublicProc SellerInfoCircumPublicProc { get; set; }

		/// <summary>
		/// Сведения о факторе (Факторинговая компания)
		/// </summary>
		/// <value><b>СвФактор</b> - сокращенное наименование (код) элемента.</value>
		public Organization FactorInfo { get; set; }

		/// <summary>
		/// Основание уступки денежного требования.
		/// </summary>
		/// <value><b>ОснУстДенТреб</b> - сокращенное наименование (код) элемента.</value>
		public Document MainAssignMonetaryClaim { get; set; }

		/// <summary>
		/// Сведения о сопроводительных документах, уточняющих обстоятельства факт хозяйственной жизни.
		/// </summary>
		/// <value><b>СопрДокФХЖ</b> - сокращенное наименование (код) элемента.</value>
		public List<Document> SupportingDocumentList {  get; set; }
	}
}
