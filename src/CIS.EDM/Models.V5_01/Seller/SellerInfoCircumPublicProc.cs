using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_01.Seller
{
    /// <summary>
    /// Информация продавца об <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/e1615ef868a1ffb29b72193405f849941cd2902b/">обстоятельствах закупок для государственных и муниципальных нужд</see>
    /// (для учета Федеральным казначейством денежных обязательств).
    /// </summary>
    /// <value><b>ИнфПродГосЗакКазн</b> - сокращенное наименование (код) элемента.</value>
    public record SellerInfoCircumPublicProc
    {
        /// <summary>
        /// Дата государственного контракта.
        /// </summary>
        /// <value><b>ДатаГосКонт</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public DateTime DateStateContract { get; set; }

        /// <summary>
        /// Номер государственного контракта.
        /// </summary>
        /// <value><b>НомерГосКонт</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string NumberStateContract { get; set; }

        /// <summary>
        /// Номер лицевого счета продавца.
        /// </summary>
        /// <value><b>ЛицСчетПрод</b> - сокращенное наименование (код) элемента.</value>
        public string PersonalAccountSeller { get; set; }

        /// <summary>
        /// Код по бюджетной классификации (продавец).
        /// </summary>
        /// <value><b>КодПродБюджКласс</b> - сокращенное наименование (код) элемента.</value>
        public string SellerBudgetClassCode { get; set; }

        /// <summary>
        /// Код цели (продавец).
        /// </summary>
        /// <value><b>КодЦелиПрод</b> - сокращенное наименование (код) элемента.</value>
        public string SellerTargetCode { get; set; }

        /// <summary>
        /// Код территориального органа Федерального казначейства продавца.
        /// </summary>
        /// <remarks>
        /// Поле заполняется в соответствии со справочником территориальных органов Федерального казначейства.
        /// </remarks>
        /// <value><b>КодКазначПрод</b> - сокращенное наименование (код) элемента.</value>
        public string SellerTreasuryCode { get; set; }

        /// <summary>
        /// Наименование территориального органа Федерального казначейства продавца.
        /// </summary>
        /// <remarks>
        /// Полное или краткое наименование территориального органа Федерального казначейства, в котором открыт лицевой счет продавца.
        /// </remarks>
        /// <value><b>НаимКазначПрод</b> - сокращенное наименование (код) элемента.</value>
        public string SellerTreasuryName { get; set; }
    }
}