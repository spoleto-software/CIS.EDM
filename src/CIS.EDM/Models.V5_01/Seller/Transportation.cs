using System.Collections.Generic;

namespace CIS.EDM.Models.V5_01.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/1d2dfaff3f9a46147ca5113dec6593d495bb9b4d/#dst101035">Транспортировка и груз.</see>
    /// </summary>
    /// <value><b>ТранГруз</b> - сокращенное наименование (код) элемента.</value>
    public record Transportation
    {
        /// <summary>
        /// Сведения о транспортировке и грузе
        /// </summary>
        /// <value><b>СвТранГруз</b> - сокращенное наименование (код) элемента.</value>
        public string TransferTextInfo { get; set; }

        /// <summary>
        /// Транспортная накладная 
        /// </summary>
        /// <remarks>
        /// Указывается в случае отгрузки с транспортировкой
        /// </remarks>
        /// <value><b>ТранНакл</b> - сокращенное наименование (код) элемента.</value>
        public List<Waybill> Waybills { get; set; }

        /// <summary>
        /// Перевозчик
        /// </summary>
        /// <remarks>
        /// Для случаев, если наличие показателя предусмотрено в установленном порядке
        /// </remarks>
        /// <value><b>Перевозчик</b> - сокращенное наименование (код) элемента.</value>
        public Organization Carrier { get; set; }
    }
}
