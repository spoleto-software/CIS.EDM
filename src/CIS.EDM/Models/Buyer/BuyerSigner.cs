using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Buyer.Reference;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// Сведения о <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/bd7db2cf0a46edbc4ca62eea69fd164893370301/">лице</see>, подписывающем файл обмена счета-фактуры (информации продавца) в электронной форме
    /// </summary>
    /// <remarks>
    /// Заполняется один из видов подписанта:
    /// <list type="table">
    ///     <item>
    ///     <term><see cref="PhysicalPerson"/></term>
    ///     <description>Физическое лицо.</description>
    ///     </item>
    ///     <item>
    ///         <term><see cref="IndividualEntrepreneur"/></term>
    ///         <description>Индивидуальный предприниматель.</description>
    ///     </item>
    ///     <item>
    ///         <term><see cref="LegalPersonRepresentative"/></term>
    ///         <description>Представитель юридического лица.</description>
    ///     </item>    
    /// </list>
    /// </remarks>
    /// <value><b>Подписант</b> - сокращенное наименование (код) элемента.</value>
    public class BuyerSigner
    {
        /// <summary>
        /// Область полномочий.
        /// </summary>
        /// <value><b>ОблПолн</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public SignerAuthority SignerAuthority { get; set; } = SignerAuthority.PersonMadeOperation;

        /// <summary>
        /// Статус.
        /// </summary>
        /// <value><b>Статус</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public SignerStatus SignerStatus { get; set; } = SignerStatus.OtherOrganizationEmployee;

        /// <summary>
        /// Основание полномочий (доверия).
        /// </summary>
        /// <remarks>
        /// Для (Статус=1 или Статус=2 или Статус=3) указываются "Должностные обязанности" по умолчанию или иные основания полномочий (доверия).<br/><br/>
        /// Для Статус=4 указываются основания полномочий (доверия).
        /// </remarks>
        /// <value><b>ОснПолн</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string SignerAuthorityBase { get; set; } = "Должностные обязанности";

        /// <summary>
        /// Основание полномочий (доверия) организации
        /// </summary>
        /// <remarks>
        /// Обязателен для Статус=3. Указываются основания полномочий (доверия) организации.
        /// </remarks>
        /// <value><b>ОснПолнОрг</b> - сокращенное наименование (код) элемента.</value>
        public string SignerOrgAuthorityBase { get; set; }

        /// <summary>
        /// Физическое лицо.
        /// </summary>
        /// <value><b>ФЛ</b> - сокращенное наименование (код) элемента.</value>
        public PhysicalPerson PhysicalPerson { get; set; }

        /// <summary>
        /// Индивидуальный предприниматель.
        /// </summary>
        /// <value><b>ИП</b> - сокращенное наименование (код) элемента.</value>
        public IndividualEntrepreneur IndividualEntrepreneur { get; set; }

        /// <summary>
        /// Представитель юридического лица.
        /// </summary>
        /// <value><b>ЮЛ</b> - сокращенное наименование (код) элемента.</value>
        public LegalPersonRepresentative LegalPersonRepresentative { get; set; }
    }
}
