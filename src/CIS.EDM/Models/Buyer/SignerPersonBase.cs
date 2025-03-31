using CIS.EDM.Models.Common;

namespace CIS.EDM.Models.Buyer
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/08f8bb6016cbc4090c0016e6698417127ea24046/#dst102297">Сведения о подписанте (информация покупателя).</see>
    /// </summary>
    /// <remarks>
    /// Базовый класс для всех подписантов:
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
    /// <value><b>ФЛ, ИП, ЮЛ</b> - сокращенное наименование (код) элемента.</value>
    public abstract record SignerPersonBase : Person
    {
        /// <summary>
        /// Иные сведения, идентифицирующие физическое лицо.
        /// </summary>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string OtherInfo { get; set; }
    }
}
