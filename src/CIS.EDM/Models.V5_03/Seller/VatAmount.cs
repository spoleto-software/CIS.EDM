﻿using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Seller
{
	/// <summary>
	/// Сумма НДС (СумНДСТип)
	/// </summary>
	public record VatAmount
	{
		/// <summary>
		/// Принимает значения от 0 (нуля) и более.
		/// </summary>
		/// <remarks>
		/// Значение «0» (ноль) формируется в случае НалСт = «0%» или в случае СтТовБезНДС = «0».
		/// При определении налоговой базы налоговыми агентами – покупателями(получателями) товаров,
		/// перечисленных в пункте 8 статьи 161 НК (значение НалСт= «НДС исчисляется налоговым агентом»), продавцами может указываться 0 (ноль; визуализируется как прочерк),
		/// в случае если иное не предусмотрено разделом II приложения № 1 к Постановлению № 1137
		/// </remarks>
		/// <value><b>СумНал</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public decimal? Amount { get; set; }

		/// <summary>
		/// Без НДС
		/// </summary>
		/// <value><b>БезНДС</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public bool WithoutVat { get; set; }
	}
}