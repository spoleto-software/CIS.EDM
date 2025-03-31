namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Основание <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">отгрузки (передачи, уступки)</see> (ОснованиеТип).
	/// </summary>
	/// <value><b>ОснПер</b> - сокращенное наименование (код) элемента.</value>
	public record TransferDocument : DocumentBase
    {
        /// <summary>
        /// Идентификатор документа-основания.
        /// </summary>
        /// <value><b>ИдентОсн</b> - сокращенное наименование (код) элемента.</value>
        public string DocumentId { get; set; }
    }
}
