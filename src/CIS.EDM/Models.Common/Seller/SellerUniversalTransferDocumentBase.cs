using CIS.EDM.Models.Common.Reference;
using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Common.Seller
{
	/// <summary>
	/// Базовый класс для информации продавца УПД.
	/// </summary>
	public abstract record SellerUniversalTransferDocumentBase : UniversalTransferDocumentBase
	{
		/// <summary>
		/// Тип участника.
		/// </summary>
		public sealed override PartyType PartyType => PartyType.Seller;

		/// <summary>
		/// Код документа по КНД
		/// </summary>
		/// <remarks>
		/// Принимает значение: 1115131.
		/// </remarks>
		/// <value><b>КНД</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string TaxDocumentCode { get; set; } = "1115131";

		/// <summary>
		/// Функция документа
		/// </summary>
		/// <value><b>Функция</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public UniversalTransferDocumentFunction Function { get; set; }

		/// <summary>
		/// Номер документа (УПД)
		/// </summary>
		/// <value><b>НомерСчФ</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string DocumentNumber { get; set; }

		/// <summary>
		/// Дата документа (УПД)
		/// </summary>
		/// <value><b>ДатаСчФ</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public DateTime DocumentDate { get; set; }

		/// <summary>
		/// Валюта: Наименование. НаимОКВ.
		/// </summary>
		/// <remarks>
		/// Код согласно Общероссийскому классификатору валют (ОКВ)
		/// </remarks>
		/// <value><b>НаимОКВ</b> - сокращенное наименование (код) элемента.</value>
		public string CurrencyName { get; set; }

		/// <summary>
		/// Курс валюты. КурсВал.
		/// </summary>
		/// <value><b>КурсВал</b> - сокращенное наименование (код) элемента.</value>
		public decimal? CurrencyRate { get; set; }

		/// <summary>
		/// Валюта: Код (строка 7 счета-фактуры).
		/// </summary>
		/// <remarks>
		/// Код согласно Общероссийскому классификатору валют (ОКВ)
		/// </remarks>
		/// <value><b>КодОКВ</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Исправление: N.
		/// </summary>
		/// <remarks>
		/// НомИспрСчФ >= 1.
		/// </remarks>
		/// <value><b>НомИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public string RevisionNumber { get; set; }

		/// <summary>
		/// Исправление: N (при составлении документа с Функция=СЧФ или Функция=СЧФДОП до внесения в него исправлений)
		/// </summary>
		/// <remarks>
		/// Принимает значение "-" (дефис) (визуализируется как прочерк).
		/// <para>При наличии <see cref="RevisionDate"/> не формируется.</para>
		/// Обязателен при отсутствии <see cref="RevisionNumber"/>.
		/// </remarks>
		/// <value><b>ДефНомИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public bool IsHyphenRevisionNumber => string.IsNullOrEmpty(RevisionNumber);

		/// <summary>
		/// Исправление: Дата
		/// </summary>
		/// <value><b>ДатаИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public DateTime? RevisionDate { get; set; }

		/// <summary>
		/// Исправление: Дата (при составлении документа с Функция=СЧФ или Функция=СЧФДОП до внесения в него исправлений)
		/// </summary>
		/// <remarks>
		/// Принимает значение "-" (дефис) (визуализируется как прочерк).
		/// <para>При наличии <see cref="RevisionDate"/> не формируется.</para>
		/// Обязателен при отсутствии <see cref="RevisionDate"/>.
		/// </remarks>
		/// <value><b>ДефДатаИспрСчФ</b> - сокращенное наименование (код) элемента.</value>
		public bool IsHyphenRevisionDate => RevisionDate == null;
	}
}
