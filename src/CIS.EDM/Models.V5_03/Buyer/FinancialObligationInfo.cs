using CIS.EDM.Models.Common.Buyer.Reference;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Информация для сведений о денежном обязательстве.</see>
	/// </summary>
	/// <value><b>ИнфСведДенОбяз</b> - сокращенное наименование (код) элемента.</value>
	public record FinancialObligationInfo
	{
		/// <summary>
		/// Номер строки таблицы информации продавца.
		/// </summary>
		/// <remarks>
		/// Повторяет НомСтр информации продавца.
		/// </remarks>
		/// <value><b>НомСтр</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public int RowNumber { get; set; }

		/// <summary>
		/// Код объекта капитального строительства федеральной адресной инвестиционной программы/код мероприятия по информатизации.
		/// </summary>
		/// <value><b>КодОбъектФАИП</b> - сокращенное наименование (код) элемента.</value>
		public string ObjectFAIPCode { get; set; }

		/// <summary>
		/// Вид средств.
		/// </summary>
		/// <remarks>
		/// Источник средств, за счет которого должна быть произведена кассовая выплата.
		/// </remarks>
		/// <value><b>ВидСредств</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public FundType FundType { get; set; } = FundType.NotSpecified;

		/// <summary>
		/// Код по бюджетной классификации (покупатель).
		/// </summary>
		/// <value><b>КодПокБюджКласс</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string BuyerBudgetClassCode { get; set; }

		/// <summary>
		/// Код цели (продавец).
		/// </summary>
		/// <value><b>КодЦелиПокуп</b> - сокращенное наименование (код) элемента.</value>
		public string BuyerTargetCode { get; set; }

		/// <summary>
		/// Сумма перечисленного аванса.
		/// </summary>
		/// <remarks>
		/// При отсутствии показателя СумАванс=0.00.
		/// </remarks>
		/// <value><b>СумАванс</b> - сокращенное наименование (код) элемента.</value>
		public decimal AmountAdvance { get; set; }
	}
}
