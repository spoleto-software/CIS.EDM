namespace CIS.EDM.Models.V5_03.Reference
{
	/// <summary>
	/// Тип подписи
	/// </summary>
	public enum SignatureType
	{
		/// <summary>
		/// усиленная квалифицированная электронная подпись   
		/// </summary>
		QualifiedElectronicSignature = 1,

		/// <summary>
		/// простая электронная подпись   
		/// </summary>
		/// <remarks>
		/// Значения «2» и «3» применяются, если иное не предусмотрено законодательством Российской Федерации
		/// </remarks>
		SimpleElectronicSignature = 2,

		/// <summary>
		/// усиленная неквалифицированная электронная подпись.
		/// </summary>
		/// <remarks>
		/// Значения «2» и «3» применяются, если иное не предусмотрено законодательством Российской Федерации
		/// </remarks>
		UnqualifiedElectronicSignature = 3
	}
}
