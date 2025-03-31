using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Buyer.Reference;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/04e48676e207e52fa7f21290c571150f67a2cd4a/#dst102169">Информация покупателя об обстоятельствах закупок для государственных и муниципальных нужд</see>
    /// (для учета Федеральным казначейством денежных обязательств).
    /// </summary>
    /// <remarks>
    /// Обязателен при осуществлении закупок для обеспечения государственных и муниципальных нужд
    /// и (или) для формирования сведений о денежном обязательстве Федеральным казначейством.
    /// </remarks>
    /// <value><b>ИнфПокГосЗакКазн</b> - сокращенное наименование (код) элемента.</value>
    public record BuyerInfoCircumPublicProc
    {
        /// <summary>
        /// Идентификационный код закупки.
        /// </summary>
        /// <value><b>ИдКодЗак</b> - сокращенное наименование (код) элемента.</value>
        public string PurchasingIdentificationCode { get; set; }

        /// <summary>
        /// Номер лицевого счета покупателя.
        /// </summary>
        /// <value><b>ЛицСчетПок</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string PersonalAccountBuyer { get; set; }

        /// <summary>
        /// Наименование финансового органа покупателя.
        /// </summary>
        /// <remarks>
        /// Принимает значение "Министерство финансов Российской Федерации",
        /// если покупатель является участником бюджетного процесса федерального уровня.<br/>
        /// Указывается наименование финансового органа соответствующего бюджета,
        /// если покупатель является участником бюджетного процесса субъекта Российской Федерации или муниципального образования.
        /// </remarks>
        /// <value><b>НаимФинОргПок</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string BuyerFinancialAuthorityName { get; set; }

        /// <summary>
        /// Номер реестровой записи покупателя по Реестру участников бюджетного процесса,
        /// а также юридических лиц, не являющихся участниками бюджетного процесса.
        /// </summary>
        /// <value><b>НомРеестрЗапПок</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string BuyerBudgetRegisterNumber { get; set; }

        /// <summary>
        /// Учетный номер бюджетного обязательства покупателя.
        /// </summary>
        /// <value><b>УчНомБюдОбязПок</b> - сокращенное наименование (код) элемента.</value>
        public string BuyerBudgetObligationAccountNumber { get; set; }

        /// <summary>
        /// Код территориального органа Федерального казначейства покупателя.
        /// </summary>
        /// <value><b>КодКазначПок</b> - сокращенное наименование (код) элемента.</value>
        public string BuyerTreasuryCode { get; set; }

        /// <summary>
        /// Наименование территориального органа Федерального казначейства покупателя.
        /// </summary>
        /// <remarks>
        /// Полное или сокращенное наименование территориального органа Федерального казначейства, в котором открыт лицевой счет покупателя.
        /// </remarks>
        /// <value><b>НаимКазначПок</b> - сокращенное наименование (код) элемента.</value>
        public string BuyerTreasuryName { get; set; }

        /// <summary>
        /// Код покупателя в Общероссийском классификаторе территорий муниципальных образований.
        /// </summary>
        /// <remarks>
        /// Принимает значение в соответствии с Общероссийским классификатором территорий муниципальных образований.
        /// </remarks>
        /// <value><b>ОКТМОПок</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string BuyerMunicipalCode { get; set; }

        /// <summary>
        /// Код места поставки в Общероссийском классификаторе территорий муниципальных образований.
        /// </summary>
        /// <remarks>
        /// Принимает значение в соответствии с Общероссийским классификатором территорий муниципальных образований.
        /// </remarks>
        /// <value><b>ОКТМОМесПост</b> - сокращенное наименование (код) элемента.</value>
        public string DeliveryMunicipalCode { get; set; }

        /// <summary>
        /// Предельная дата оплаты.
        /// </summary>
        /// <remarks>
        /// Дата в формате ДД.ММ.ГГГГ.
        /// </remarks>
        /// <value><b>ДатаОплПред</b> - сокращенное наименование (код) элемента.</value>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Учетный номер денежного обязательства.
        /// </summary>
        /// <remarks>
        /// Обязателен для заполнения при внесении изменений в ранее направленный в Федеральное казначейство документ,
        /// по которому было поставлено на учет денежное обязательство.
        /// </remarks>
        /// <value><b>УчНомДенОбяз</b> - сокращенное наименование (код) элемента.</value>
        public string FinancialObligationAccountNumber { get; set; }

        /// <summary>
        /// Очередность платежа.
        /// </summary>
        /// <remarks>
        /// Обязателен при заполнении <see cref="PaymentDate"/>.
        /// </remarks>
        /// <value><b>ОчерПлат</b> - сокращенное наименование (код) элемента.</value>
        public string PaymentOrder { get; set; }

        /// <summary>
        /// Вид платежа.
        /// </summary>
        /// <remarks>
        /// Обязателен при заполнении <see cref="PaymentDate"/>.
        /// </remarks>
        /// <value><b>ВидПлат</b> - сокращенное наименование (код) элемента.</value>
        public PaymentType PaymentType { get; set; } = PaymentType.NotSpecified;

        /// <summary>
        /// Информация для сведений о денежном обязательстве.
        /// </summary>
        /// <value><b>ИнфСведДенОбяз</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public List<FinancialObligationInfo> FinancialObligationInfoList { get; set; }
    }
}
