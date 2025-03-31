
using CIS.EDM.Exceptions;
using CIS.EDM.Models.Common.Buyer;
using CIS.EDM.Models.Common.Reference;
using CIS.EDM.Models.V5_03.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// Информация покупателя УПД согласно <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024)</see>
	/// </summary>
	/// <value><b>Файл</b> - сокращенное наименование (код) элемента.</value>
	public record BuyerUniversalTransferDocument : BuyerUniversalTransferDocumentBase
	{
		public const string FileIdPattern = "ON_NSCHFDOPPOK";

		/// <summary>
		/// Версия формата.
		/// </summary>
		/// <remarks>
		/// Принимает значение: 5.03.
		/// </remarks>
		/// <value><b>ВерсФорм</b> - сокращенное наименование (код) элемента.</value>
		public override string FormatVersion { get; set; } = Constants.FormatVersion503;

		/// <summary>
		/// Экономический субъект - составитель файла обмена счета-фактуры (информации продавца).
		/// </summary>
		/// <value><b>НаимЭконСубСост</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public Organization DocumentCreator { get; set; }

		/// <summary>
		/// Основание, по которому экономический субъект является составителем файла обмена счета-фактуры (информации продавца).
		/// </summary>
		/// <remarks>
		/// Обязателен, если <see cref="DocumentCreator"> составитель информации покупателя</see> не является покупателем.
		/// </remarks>
		/// <value><b>ОснДоверОргСост</b> - сокращенное наименование (код) элемента.</value>
		public Document DocumentCreatorBase { get; set; }

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

		/// <summary>
		/// Сведения о принятии товаров (результатов выполненных работ), имущественных прав (о подтверждении факта оказания услуг).
		/// </summary>
		/// <value><b>СвПрин</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public AcceptanceInfo AcceptanceInfo { get; set; }

		/// <summary>
		/// Информационное поле факта хозяйственной жизни 4.
		/// </summary>
		/// <value><b>ИнфПолФХЖ4</b> - сокращенное наименование (код) элемента.</value>
		public OtherEconomicInfo4 OtherEconomicInfo { get; set; }

		/// <summary>
		/// Информация покупателя об обстоятельствах закупок для государственных и муниципальных нужд
		/// (для учета Федеральным казначейством денежных обязательств).
		/// </summary>
		/// <remarks>
		/// Обязателен при осуществлении закупок для обеспечения государственных и муниципальных нужд
		/// и (или) для формирования сведений о денежном обязательстве Федеральным казначейством.
		/// </remarks>
		/// <value><b>ИнфПокГосЗакКазн</b> - сокращенное наименование (код) элемента.</value>
		public BuyerInfoCircumPublicProc BuyerInfoCircumPublicProc { get; set; }

		/// <summary>
		/// Сведения о лице, подписывающем файл обмена информации покупателя в электронной форме.
		/// </summary>
		/// <value><b>Подписант</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public List<BuyerSigner> Signers { get; set; }

		/// <summary>
		/// Получение типа УПД.
		/// </summary>
		protected override List<TransferDocumentType> GetTransferDocumentTypes()
		{
			var types = new List<TransferDocumentType> { TransferDocumentType.Default };
			if (SellerDocumentInfo is SellerDocumentInfo sellerDocumentInfo)
			{
				//R_Т_A_О_GGGGMMDD_N1_N2_N3_N4_N5_N6_N7 
				var fileId = sellerDocumentInfo.FileId;
				var modifiers = fileId[^12..].Split('_');
				if (modifiers.Length < 6)
					throw new FormatVersionException($"Версия файла продавца не соответствует версии информации покупателя <{FormatVersion}>.");

				if (modifiers[0] == "1")
					types.Add(TransferDocumentType.Proc);

				if (modifiers[1] == "1")
					types.Add(TransferDocumentType.Mark);

				if (modifiers[2] == "1")
					types.Add(TransferDocumentType.Beer);

				if (modifiers[3] == "1")
					types.Add(TransferDocumentType.Tobacco);

				if (modifiers[4] == "1")
					types.Add(TransferDocumentType.Oil);
			}

			return types;
		}

		/// <summary>
		/// Получение идентификатора файла.
		/// </summary>
		protected override string GetFileId()
		{
			var transferDocumentTypes = TransferDocumentTypes;
			
			var n1 = Guid.NewGuid().ToString("D");
			
			var n2 = transferDocumentTypes.Contains(TransferDocumentType.Proc) ? "1" : "0";
			var n3 = transferDocumentTypes.Contains(TransferDocumentType.Mark) ? "1" : "0";
			var n4 = transferDocumentTypes.Contains(TransferDocumentType.Beer) ? "1" : "0";
			var n5 = transferDocumentTypes.Contains(TransferDocumentType.Tobacco) ? "1" : "0";
			var n6 = transferDocumentTypes.Contains(TransferDocumentType.Oil) ? "1" : "0";
			var n7 = "00";

			return $"{FileIdPattern}_{RecipientEdmParticipant.FullId}_{SenderEdmParticipant.FullId}_{DateCreation:yyyyMMdd}_{n1}_{n2}_{n3}_{n4}_{n5}_{n6}_{n7}";
		}
	}
}
