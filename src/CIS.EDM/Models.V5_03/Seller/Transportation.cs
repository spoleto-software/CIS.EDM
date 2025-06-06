namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/d552ee61efc831d3b939a200296fc6f907a34ab2/">Транспортировка.</see>
	/// </summary>
	/// <value><b>ТранГруз</b> - сокращенное наименование (код) элемента.</value>
	public record Transportation
    {
        /// <summary>
        /// Сведения о транспортировке
        /// </summary>
        /// <value><b>СвТранГруз</b> - сокращенное наименование (код) элемента.</value>
        public string TransferTextInfo { get; set; }

		/// <summary>
		/// Значение в соответствии с международными правилами толкования торговых терминов (далее – международные правила)
		/// </summary>
		/// <remarks>
		/// Принимает значение в соответствии с международными правилами
		/// </remarks>
		/// <value><b>Инкотермс</b> - сокращенное наименование (код) элемента.</value>
		public string Incoterms { get; set; }

		/// <summary>
		/// Версия международных правил
		/// </summary>
		/// <remarks>
		/// Приводится в структуре ХХХХ, где:
		/// ХХХХ – год опубликования международных правил
		/// </remarks>
		/// <value><b>ВерИнкотермс</b> - сокращенное наименование (код) элемента.</value>
		public string IncotermsVersion { get; set; }
	}
}
