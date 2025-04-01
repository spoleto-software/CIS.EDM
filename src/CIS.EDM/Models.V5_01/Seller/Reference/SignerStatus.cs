namespace CIS.EDM.Models.V5_01.Buyer.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/08f8bb6016cbc4090c0016e6698417127ea24046/#dst102297">Статус.</see>
    /// </summary>
    /// <value><b>Статус</b> - сокращенное наименование (код) элемента.</value>
    public enum SignerStatus
    {
        /// <summary>
        /// Работник иной уполномоченной организации.
        /// </summary>
        /// <value>3</value>
        OtherOrganizationEmployee = 3,

        /// <summary>
        /// Уполномоченное физическое лицо (в том числе индивидуальный предприниматель).
        /// </summary>
        /// <value>4</value>
        AuthorizedPerson = 4,

        /// <summary>
        /// Работник организации покупателя.
        /// </summary>
        /// <value>1</value>
        BuyerEmployee = 5,

        /// <summary>
        /// Работник организации - составителя файла обмена информации покупателя, если составитель файла обмена информации покупателя не является покупателем.
        /// </summary>
        /// <value>2</value>
        InformationCreatorEmployee = 6
    }
}
