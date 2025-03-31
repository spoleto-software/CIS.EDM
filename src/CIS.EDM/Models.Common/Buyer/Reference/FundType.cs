namespace CIS.EDM.Models.Common.Buyer.Reference
{
    /// <summary>
    /// Вид средств.
    /// </summary>
    /// <remarks>
    /// Источник средств, за счет которого должна быть произведена кассовая выплата.
    /// </remarks>
    /// <value><b>ВидСредств</b> - сокращенное наименование (код) элемента.</value>
    public enum FundType
    {
        /// <summary>
        /// Неопределено.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// Средства бюджета.
        /// </summary>
        Budget = 1,

        /// <summary>
        /// Средства дополнительного бюджетного финансирования
        /// </summary>
        AdditionalBudget = 3,

        /// <summary>
        /// Средства для финансирования мероприятий по оперативно-розыскной деятельности.
        /// </summary>
        OperationalSearchActivity = 4,

        /// <summary>
        /// Средства, поступающие во временное распоряжение казенных учреждений.
        /// </summary>
        StateInstitutionsTemporary = 5,

        /// <summary>
        /// Средства юридических лиц.
        /// </summary>
        LegalEntity = 6
    }
}
