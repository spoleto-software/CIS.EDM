using System.Collections.Generic;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Транспортировка и груз.</see>
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
