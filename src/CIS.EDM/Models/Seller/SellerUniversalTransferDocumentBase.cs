﻿using CIS.EDM.Models.Reference;
using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.Seller
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
		/// Уникальный идентификатор документа.
		/// </summary>
		/// <remarks>
		/// Выдается государственной информационной системой (при необходимости)
		/// </remarks>
		/// <value><b>УИД</b> - сокращенное наименование (код) элемента.</value>
		public string DocumentUid { get; set; }

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
		/// Валюта: Наименование. НаимОКВ.
		/// </summary>
		/// <remarks>
		/// Код согласно Общероссийскому классификатору валют (ОКВ)
		/// </remarks>
		/// <value><b>НаимОКВ</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string CurrencyName { get; set; }

		/// <summary>
		/// Курс валюты. КурсВал.
		/// </summary>
		/// <value><b>КурсВал</b> - сокращенное наименование (код) элемента.</value>
		public decimal? CurrencyRate { get; set; }
	}
}
