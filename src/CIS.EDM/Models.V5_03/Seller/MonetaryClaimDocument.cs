namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Основание уступки денежного требования.</see>
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