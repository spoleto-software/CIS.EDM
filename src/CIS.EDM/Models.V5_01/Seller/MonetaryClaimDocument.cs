﻿namespace CIS.EDM.Models.V5_01.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/3e05a68185b9ed4a68894da5cd72fdb9d3a38d1f/#dst101621">Основание уступки денежного требования.</see>
    /// </summary>
    /// <value><b>ОснУстДенТреб</b> - сокращенное наименование (код) элемента.</value>
    public record MonetaryClaimDocument : DocumentBase
    {
        /// <summary>
        /// Идентификатор документа-основания
        /// </summary>
        /// <value><b>ИдентОсн</b> - сокращенное наименование (код) элемента.</value>
        public string DocumentId { get; set; }
    }
}