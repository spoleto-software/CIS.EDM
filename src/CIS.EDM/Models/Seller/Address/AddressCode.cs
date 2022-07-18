namespace CIS.EDM.Models.Seller.Address
{
    /// <summary>
    /// Уникальный номер адреса объекта адресации в государственном адресном реестре
    /// </summary>
    public class AddressCode
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