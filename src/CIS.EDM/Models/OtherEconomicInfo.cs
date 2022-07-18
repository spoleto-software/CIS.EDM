using System.Collections.Generic;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Информационное поле факта хозяйственной жизни.
    /// </summary>
    public abstract class OtherEconomicInfo
    {
        /// <summary>
        /// Идентификатор файла информационного поля
        /// </summary>
        /// <remarks>
        /// GUID.
        /// Указывается идентификатор файла, связанного со сведениями данного электронного документа.
        /// </remarks>
        /// <value><b>ИдФайлИнфПол</b> - сокращенное наименование (код) элемента.</value>
        public string InfoFileId { get; set; }

        /// <summary>
        /// Текстовая информация.
        /// </summary>
        /// <value><b>ТекстИнф</b> - сокращенное наименование (код) элемента.</value>
        public List<OtherEconomicInfoItem> Items { get; set; }
    }
}