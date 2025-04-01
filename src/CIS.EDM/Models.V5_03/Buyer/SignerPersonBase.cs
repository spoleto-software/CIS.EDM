namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/">Сведения о подписанте (информация покупателя).</see>
	/// </summary>
	public abstract record SignerPersonBase : Person
	{
		/// <summary>
		/// Иные сведения, идентифицирующие физическое лицо.
		/// </summary>
		/// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
		public string OtherInfo { get; set; }
	}
}
