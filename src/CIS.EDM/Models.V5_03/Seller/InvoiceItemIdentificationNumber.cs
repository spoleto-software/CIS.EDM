using System.Collections.Generic;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Номер средств идентификации товаров (НомСредИдентТов).
	/// </summary>
	/// <value><b>НомСредИдентТов</b> - сокращенное наименование (код) элемента.</value>
	public record InvoiceItemIdentificationNumber
	{
		/// <summary>
		/// Уникальный идентификатор транспортной упаковки
		/// </summary>
		/// <remarks>
		/// Например, SSCC.<br/>
		/// Обязателен при отсутствии <see cref="MarkItems"/>, <see cref="MarkedProductQuantity"/> и <see cref="SecondaryPackageItems"/>.
		/// </remarks>
		/// <value><b>ИдентТрансУпак</b> - сокращенное наименование (код) элемента.</value>
		public string PackageId { get; set; }

		/// <summary>
		/// Количество товара в единицах измерения маркированного товара средствами идентификации
		/// </summary>
		/// <remarks>
		/// Указывается количество маркированных товаров в потребительской упаковке (КИЗ).<br/>
		/// Элемент обязателен при отсутствии <see cref="MarkItems"/>, <see cref="SecondaryPackageItems"/> и <see cref="PackageId"/>.
		/// </remarks>
		/// <value><b>КолВедМарк</b> - сокращенное наименование (код) элемента.</value>
		public string MarkedProductQuantity { get; set; } // КолВедМарк

		/// <summary>
		/// Производственная партия (КОД)
		/// </summary>
		/// <value><b>ПрПартМарк</b> - сокращенное наименование (код) элемента.</value>
		public string ProductionBatchCode { get; set; } // ПрПартМарк

		/// <summary>
		/// Контрольный идентификационный знак (КИЗ).
		/// </summary>
		/// <remarks>
		/// Обязателен при отсутствии <see cref="PackageId"/>, <see cref="SecondaryPackageItems"/> и <see cref="MarkedProductQuantity"/>.
		/// </remarks>
		/// <value>
		/// <b>КИЗ</b> - сокращенное наименование (код) элемента.<br/>
		/// </value>
		public List<string> MarkItems { get; set; }

		/// <summary>
		/// Уникальный идентификатор вторичной (потребительской)/третичной (заводской, транспортной) упаковки.
		/// </summary>
		/// <remarks>
		/// Обязателен при отсутствии <see cref="PackageId"/>, <see cref="MarkItems"/> и <see cref="MarkedProductQuantity"/>.
		/// </remarks>
		/// <value>
		/// <b>НомУпак</b> - сокращенное наименование (код) элемента.
		/// </value>
		public List<string> SecondaryPackageItems { get; set; }
	}
}