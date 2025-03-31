namespace CIS.EDM.Models.V5_03.Seller.Address
{
    /// <summary>
    /// Уникальный номер адреса объекта адресации в государственном адресном реестре
    /// </summary>
    public record AddressCode
    {
        /// <summary>
        /// Уникальный номер адреса объекта адресации в государственном адресном реестре
        /// </summary>
        /// <value><b>КодГАР</b> - сокращенное наименование (код) элемента.</value>
        public string UniqueCode { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => UniqueCode;
    }
}