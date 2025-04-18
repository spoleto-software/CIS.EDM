﻿using CIS.EDM.Models.Buyer;
using CIS.EDM.Models.Reference;
using CIS.EDM.Models.V5_01.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_01.Buyer
{
	/// <summary>
	/// Информация покупателя УПД согласно <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/042ba1c6d0cfc8bc7fb2b7b3a089f50826006b94/">приказа ФНС России от 19.12.2018 № ММВ-7-15/820@</see>.
	/// </summary>
	/// <value><b>Файл</b> - сокращенное наименование (код) элемента.</value>
	[Obsolete("Use CIS.EDM.Models.V5_03.Buyer.BuyerUniversalTransferDocument with format 5.03")]
	public record BuyerUniversalTransferDocument : BuyerUniversalTransferDocumentBase
	{
		public const string FileIdPattern = "ON_NSCHFDOPPOK";
		public const string FileWithProcIdPattern = "ON_NSCHFDOPPOKPROS";
		public const string FileWithMarkIdPattern = "ON_NSCHFDOPPOKMARK";

		/// <summary>
		/// Версия формата.
		/// </summary>
		/// <remarks>
		/// Принимает значение: 5.01.
		/// </remarks>
		/// <value><b>ВерсФорм</b> - сокращенное наименование (код) элемента.</value>
		public override string FormatVersion { get; set; } = Constants.FormatVersion;

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
		public string DocumentCreatorBase { get; set; }

		/// <summary>
		/// Оператор ЭДО.
		/// </summary>
		/// <value><b>СвОЭДОтпр</b> - сокращенное наименование (код) элемента.</value>
		public EdmOperator EdmOperator { get; set; }

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
		/// <remarks>
		/// Заполняется один из видов подписанта:
		/// <list type="table">
		///     <item>
		///     <term><see cref="BuyerSigner.PhysicalPerson"/></term>
		///     <description>Физическое лицо.</description>
		///     </item>
		///     <item>
		///         <term><see cref="BuyerSigner.IndividualEntrepreneur"/></term>
		///         <description>Индивидуальный предприниматель.</description>
		///     </item>
		///     <item>
		///         <term><see cref="BuyerSigner.LegalPersonRepresentative"/></term>
		///         <description>Представитель юридического лица.</description>
		///     </item>    
		/// </list>
		/// </remarks>
		/// <value><b>Подписант</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public List<BuyerSigner> Signers { get; set; }

		/// <summary>
		/// Получение типа УПД.
		/// </summary>
		protected override List<TransferDocumentType> GetTransferDocumentTypes()
		{
			var types = new List<TransferDocumentType> { TransferDocumentType.Mark };
			//if (SellerDocumentInfo is SellerDocumentInfo sellerDocumentInfo)
			//{
			//    if (sellerDocumentInfo.FileId.StartsWith(SellerUniversalTransferDocument.FileWithMarkIdPattern))
			//        types.Add(TransferDocumentType.Mark);

			//    if (sellerDocumentInfo.FileId.StartsWith(SellerUniversalTransferDocument.FileWithProcIdPattern))
			//        types.Add(TransferDocumentType.Proc);
			//}

			return types;
		}

		/// <summary>
		/// Получение идентификатора файла.
		/// </summary>
		protected override string GetFileId()
		{
			var type = TransferDocumentTypes[0];

			var pattern = type switch
			{
				TransferDocumentType.Default => FileIdPattern,
				TransferDocumentType.Proc => FileWithProcIdPattern,
				TransferDocumentType.Mark => FileWithMarkIdPattern,
				_ => throw new ArgumentException(message: "Некорректный тип УПД", paramName: nameof(TransferDocumentType)),
			};

			return $"{pattern}_{RecipientEdmParticipant.FullId}_{SenderEdmParticipant.FullId}_{DateCreation:yyyyMMdd}_{Guid.NewGuid():D}";
		}
	}
}
