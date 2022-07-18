using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Reference;
using CIS.EDM.Models.Seller;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// Информация покупателя УПД согласно <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/042ba1c6d0cfc8bc7fb2b7b3a089f50826006b94/">приказу ФНС России от 19.12.2018 № ММВ-7-15/820@</see>.
    /// </summary>
    /// <value><b>Файл</b> - сокращенное наименование (код) элемента.</value>
    public class BuyerUniversalTransferDocument : UniversalTransferDocumentBase
    {
        internal const string FileIdPattern = "ON_NSCHFDOPPOK}";
        internal const string FileWithProcIdPattern = "ON_NSCHFDOPPOKPROS";
        internal const string FileWithMarkIdPattern = "ON_NSCHFDOPPOKMARK";

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
        /// Основание, по которому экономический субъект является составителем файла обмена счета-фактуры (информации продавца).
        /// </summary>
        /// <remarks>
        /// Обязателен, если <see cref="UniversalTransferDocumentBase.DocumentCreator"> составитель информации покупателя</see> не является покупателем.
        /// </remarks>
        /// <value><b>ОснДоверОргСост</b> - сокращенное наименование (код) элемента.</value>
        public string DocumentCreatorBase { get; set; }

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
        protected override TransferDocumentType GetTransferDocumentType()
        {
            if (SellerDocumentInfo is SellerDocumentInfo sellerDocumentInfo)
            {
                if (sellerDocumentInfo.FileId.StartsWith(SellerUniversalTransferDocument.FileWithMarkIdPattern))
                    return TransferDocumentType.Mark;

                if (sellerDocumentInfo.FileId.StartsWith(SellerUniversalTransferDocument.FileWithProcIdPattern))
                    return TransferDocumentType.Proc;
            }

            return TransferDocumentType.Default;
        }

        /// <summary>
        /// Получение идентификатора файла.
        /// </summary>
        protected override string GetFileId()
        {
            var pattern = TransferDocumentType switch
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
