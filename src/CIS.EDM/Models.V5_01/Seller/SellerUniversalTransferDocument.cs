﻿using CIS.EDM.Models.Reference;
using CIS.EDM.Models.Seller;
using CIS.EDM.Models.V5_01.Seller.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CIS.EDM.Models.V5_01.Seller
{
	/// <summary>
	/// Информация продавца УПД согласно <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/72c0ce050134c39638806ac35cafbdce970d54ee/">приказа ФНС России от 19.12.2018 № ММВ-7-15/820@</see>.
	/// </summary>
	/// <value><b>Файл</b> - сокращенное наименование (код) элемента.</value>
	[Obsolete("Use CIS.EDM.Models.V5_03.Seller.SellerUniversalTransferDocument with format 5.03")]
	public record SellerUniversalTransferDocument : SellerUniversalTransferDocumentBase
	{
		public const string FileIdPattern = "ON_NSCHFDOPPR";
		public const string FileWithProcIdPattern = "ON_NSCHFDOPPRPROS";
		public const string FileWithMarkIdPattern = "ON_NSCHFDOPPRMARK";

		/// <summary>
		/// Версия формата.
		/// </summary>
		/// <remarks>
		/// Принимает значение: 5.01.
		/// </remarks>
		/// <value><b>ВерсФорм</b> - сокращенное наименование (код) элемента.</value>
		public override string FormatVersion { get; set; } = Constants.FormatVersion;

		/// <summary>
		/// Исправление: N.
		/// </summary>
		/// <remarks>
		/// НомИспрСчФ >= 1.
		/// </remarks>
		/// <value><b>НомИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public string RevisionNumber { get; set; }

		/// <summary>
		/// Исправление: Дата
		/// </summary>
		/// <value><b>ДатаИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public DateTime? RevisionDate { get; set; }

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
		/// Обязателен, если <see cref="DocumentCreator">составитель информации продавца</see> не является <see cref="Sellers">продавцом</see>.
		/// </remarks>
		/// <value><b>ОснДоверОргСост</b> - сокращенное наименование (код) элемента.</value>
		public string DocumentCreatorBase { get; set; }

		/// <summary>
		/// Оператор ЭДО.
		/// </summary>
		/// <value><b>СвОЭДОтпр</b> - сокращенное наименование (код) элемента.</value>
		public EdmOperator EdmOperator { get; set; }

		/// <summary>
		/// Сведения о продавце (строки 2, 2а, 2б счета-фактуры).
		/// </summary>
		/// <value><b>СвПрод</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public List<Organization> Sellers { get; set; }

		/// <summary>
		/// Сведения о покупателе (строки 6, 6а, 6б счета-фактуры).
		/// </summary>
		/// <value><b>СвПокуп</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public List<Organization> Buyers { get; set; }

		/// <summary>
		/// Сведения таблицы счета-фактуры (содержание факта хозяйственной жизни 2 - наименование и другая информация об отгруженных товарах (выполненных работах, оказанных услугах), о переданных имущественных правах.
		/// </summary>
		/// <value><b>ТаблСчФакт</b> - сокращенное наименование (код) элемента.</value>
		public List<InvoiceItem> Items { get; set; }

		/// <summary>
		/// Сведения о лице, подписывающем файл обмена счета-фактуры (информации продавца) в электронной форме.
		/// </summary>
		/// <remarks>
		/// Заполняется один из видов подписанта:
		/// <list type="table">
		///     <item>
		///     <term><see cref="SellerSigner.PhysicalPerson"/></term>
		///     <description>Физическое лицо.</description>
		///     </item>
		///     <item>
		///         <term><see cref="SellerSigner.IndividualEntrepreneur"/></term>
		///         <description>Индивидуальный предприниматель.</description>
		///     </item>
		///     <item>
		///         <term><see cref="SellerSigner.LegalPersonRepresentative"/></term>
		///         <description>Представитель юридического лица.</description>
		///     </item>    
		/// </list>
		/// </remarks>
		/// <value><b>Подписант</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public List<SellerSigner> Signers { get; set; }

		#region Additional properties:

		/// <summary>
		/// Грузоотправители.
		/// </summary>
		/// <value><b>ГрузОтпр</b> - сокращенное наименование (код) элемента.</value>
		public List<Organization> Shippers { get; set; }

		/// <summary>
		/// Грузополучатели.
		/// </summary>
		/// <value><b>ГрузПолуч</b> - сокращенное наименование (код) элемента.</value>
		public List<Organization> Consignees { get; set; }

		/// <summary>
		/// Содержание факта хозяйственной жизни 3 - сведения о факте отгрузки товаров (выполнения работ), передачи имущественных прав (о предъявлении оказанных услуг).
		/// </summary>
		/// <remarks>
		/// Документ о переходе права собственности.
		/// </remarks>
		/// <value><b>СвПродПер</b> - сокращенное наименование (код) элемента.</value>
		public TransferInfo TransferInfo { get; set; }

		/// <summary>
		/// Реквизиты документов, подтверждающих отгрузку товаров (работ, услуг, имущественных прав)
		/// </summary>
		/// <value><b>ДокПодтвОтгр</b> - сокращенное наименование (код) элемента.</value>
		public List<TransferDocumentShipmentInfo> DocumentShipmentList { get; set; }

		/// <summary>
		/// Информационное поле факта хозяйственной жизни 1
		/// </summary>
		/// <value><b>ИнфПолФХЖ1</b> - сокращенное наименование (код) элемента.</value>
		public OtherEconomicInfo1 OtherEconomicInfo { get; set; }

		/// <summary>
		/// Сведения о платежно-расчетном документе
		/// </summary>
		/// <value><b>СвПРД</b> - сокращенное наименование (код) элемента.</value>
		public List<PaymentDocumentInfo> PaymentDocumentInfoList { get; set; }

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
		/// Сведения о факторе (Факторинговая компания)
		/// </summary>
		/// <value><b>СвФактор</b> - сокращенное наименование (код) элемента.</value>
		public Organization FactorInfo { get; set; }

		/// <summary>
		/// Обстоятельства формирования счета-фактуры, применяемого при расчетах по налогу на добавленную стоимость
		/// </summary>
		/// <value><b>ОбстФормСЧФ</b> - сокращенное наименование (код) элемента.</value>
		public InvoiceFormationType InvoiceFormationType { get; set; }

		/// <summary>
		/// Информация продавца об обстоятельствах закупок для государственных и муниципальных нужд
		/// (для учета Федеральным казначейством денежных обязательств)
		/// </summary>
		/// <value><b>ИнфПродГосЗакКазн</b> - сокращенное наименование (код) элемента.</value>
		public SellerInfoCircumPublicProc SellerInfoCircumPublicProc { get; set; }

		/// <summary>
		/// Основание уступки денежного требования.
		/// </summary>
		/// <value><b>ОснУстДенТреб</b> - сокращенное наименование (код) элемента.</value>
		public MonetaryClaimDocument MainAssignMonetaryClaim { get; set; }

		/// <summary>
		/// Наименование первичного документа, определенное организацией (согласованное сторонами сделки)
		/// </summary>
		/// <remarks>
		/// Если не передать, то заполнится автоматом на основе <see cref="SellerUniversalTransferDocumentBase.Function"/>.
		/// </remarks>
		/// <value><b>НаимДокОпр</b> - сокращенное наименование (код) элемента.</value>
		public string DocumentName { get; set; }

		/// <summary>
		/// Наименование документа по факту хозяйственной жизни
		/// </summary>
		/// <remarks>
		/// Если не передать, то заполнится автоматом на основе <see cref="SellerUniversalTransferDocumentBase.Function"/>.
		/// </remarks>
		/// <value><b>ПоФактХЖ</b> - сокращенное наименование (код) элемента.</value>
		public string DocumentEconomicName { get; set; }

		/// <summary>
		/// Информация о наличии согласованной структуры дополнительных информационных полей.
		/// </summary>
		/// <remarks>
		/// Заполняется в случае формирования документа по договоренности сторон по настоящему формату
		/// с учетом согласованной структуры дополнительной информации
		/// Принимает значение XXXX.YYYY.NNNN, где XXXX, YYYY и NNNN содержат информацию,
		/// позволяющую соответственно отправителю, получателю файла обмена счета-фактуры(информации продавца)
		/// и третьей стороне(при соответствующем согласовании) в автоматизированном режиме обрабатывать информацию,
		/// содержащуюся в информационных полях данного документа.NNNN принимает значение "0000".
		/// </remarks>
		/// <value><b>СоглСтрДопИнф</b> - сокращенное наименование (код) элемента.</value>
		public string ApprovedStructureAdditionalInfoFields { get; set; }

		/// <summary>
		/// Исправление: N (при составлении документа с Функция=СЧФ или Функция=СЧФДОП до внесения в него исправлений)
		/// </summary>
		/// <remarks>
		/// Принимает значение "-" (дефис) (визуализируется как прочерк).
		/// <para>При наличии <see cref="RevisionDate"/> не формируется.</para>
		/// Обязателен при отсутствии <see cref="RevisionNumber"/>.
		/// </remarks>
		/// <value><b>ДефНомИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public bool IsHyphenRevisionNumber => string.IsNullOrEmpty(RevisionNumber);

		/// <summary>
		/// Исправление: Дата (при составлении документа с Функция=СЧФ или Функция=СЧФДОП до внесения в него исправлений)
		/// </summary>
		/// <remarks>
		/// Принимает значение "-" (дефис) (визуализируется как прочерк).
		/// <para>При наличии <see cref="RevisionDate"/> не формируется.</para>
		/// Обязателен при отсутствии <see cref="RevisionDate"/>.
		/// </remarks>
		/// <value><b>ДефДатаИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public bool IsHyphenRevisionDate => RevisionDate == null;

		#endregion END Additional properties

		/// <summary>
		/// Получение типа УПД.
		/// </summary>
		protected override List<TransferDocumentType> GetTransferDocumentTypes()
		{
			if (Items?.Count > 0)
			{
				if (Items.Any(x => x.AdditionalInfo?.ItemIdentificationNumberList?.Count > 0))
					return [TransferDocumentType.Mark];

				else if (Items.Any(x => x.AdditionalInfo?.ItemTracingInfoList?.Count > 0))
					return [TransferDocumentType.Proc];
			}

			return [TransferDocumentType.Default];
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
