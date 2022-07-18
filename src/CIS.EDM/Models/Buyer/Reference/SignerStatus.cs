namespace CIS.EDM.Models.Seller.Reference
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/bd7db2cf0a46edbc4ca62eea69fd164893370301/">Статус.</see>
    /// </summary>
    /// <value><b>Статус</b> - сокращенное наименование (код) элемента.</value>
    public enum SignerStatus
    {
        /// <summary>
        /// Работник организации продавца товаров (работ, услуг, имущественных прав).
        /// </summary>
        /// <value>1</value>
        SellerEmployee = 1,

        /// <summary>
        /// Работник организации - составителя файла обмена информации продавца, если составитель файла обмена информации не является продавцом.
        /// </summary>
        /// <value>2</value>
        InformationCreatorEmployee = 2,

        /// <summary>
        /// Работник иной уполномоченной организации.
        /// </summary>
        /// <value>3</value>
        OtherOrganizationEmployee = 3,

        /// <summary>
        /// Уполномоченное физическое лицо (в том числе индивидуальный предприниматель).
        /// </summary>
        /// <value>4</value>
        AuthorizedPerson = 4
    }
}
