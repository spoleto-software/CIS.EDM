namespace CIS.EDM.Models.V5_01.Seller.Address
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/e9707afe452883ee7fd9f6f40274598916c8a5ca/#dst101377">Сведения об адресе.</see>
    /// </summary>
    /// <remarks>
    /// Заполняется один из видов адреса:
    /// <list type="table">
    ///     <item>
    ///     <term><see cref="RussianAddress"/></term>
    ///     <description>адрес РФ</description>
    ///     </item>
    ///     <item>
    ///         <term><see cref="ForeignAddress"/></term>
    ///         <description>адрес за пределами РФ</description>
    ///     </item>
    ///     <item>
    ///         <term><see cref="AddressCode"/></term>
    ///         <description>уникальный номер адреса объекта адресации в государственном адресном реестре.</description>
    ///     </item>    
    /// </list>
    /// </remarks>
    /// <value><b>Адрес</b> - сокращенное наименование (код) элемента.</value>
    public record Address
    {
        /// <summary>
        /// Адрес, указанный в Едином государственном реестре юридических лиц/почтовый адрес/адрес места жительства
        /// индивидуального предпринимателя (реквизиты адреса на территории Российской Федерации).
        /// </summary>
        /// <value><b>АдрРФ</b> - сокращенное наименование (код) элемента.</value>
        public RussianAddress RussianAddress { get; set; }

        /// <summary>
        /// Адрес, указанный в Едином государственном реестре юридических лиц/почтовый адрес/адрес места жительства
        /// индивидуального предпринимателя (информация об адресе, в том числе об адресе за пределами территории Российской Федерации).
        /// </summary>
        /// <value><b>АдрИнф</b> - сокращенное наименование (код) элемента.</value>
        public ForeignAddress ForeignAddress { get; set; }

        /// <summary>
        /// Уникальный номер адреса объекта адресации в государственном адресном реестре.
        /// </summary>
        /// <value><b>КодГАР</b> - сокращенное наименование (код) элемента.</value>
        public AddressCode AddressCode { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{RussianAddress?.ToString() ?? ForeignAddress?.ToString() ?? AddressCode?.ToString()}";
    }
}
