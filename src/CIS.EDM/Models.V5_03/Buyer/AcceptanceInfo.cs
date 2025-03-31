using System;

namespace CIS.EDM.Models.V5_03.Buyer
{
	/// <summary>
	/// <see href="https://www.consultant.ru/document/cons_doc_LAW_468229/c8167b9154e8563f2f704e552be349e55e928aca/">Сведения о принятии товаров (результатов выполненных работ), имущественных прав (о подтверждении факта оказания услуг).</see>
	/// </summary>
	/// <value><b>СвПрин</b> - сокращенное наименование (код) элемента.</value>
	public record AcceptanceInfo
    {
        /// <summary>
        /// Содержание операции (текст).
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="OperationNameInfo"/>.<br/><br/>
        /// Содержание действий.<br/>
        /// Указывается, например, "Товары принял без претензий", "Результаты работ принял без претензий", "Услуги получены, претензий нет" или другое.
        /// </remarks>
        /// <value><b>СодОпер</b> - сокращенное наименование (код) элемента.</value>
        public string OperationName { get; set; }

        /// <summary>
        /// Дата принятия товаров (результатов выполненных работ), имущественных прав (подтверждения факта оказания услуг).
        /// </summary>
        /// <remarks>
        /// Обязателен, если дата получения груза не совпадает с ДатаПер информации продавца.
        /// </remarks>
        /// <value><b>ДатаПрин</b> - сокращенное наименование (код) элемента.</value>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Код содержания операции.
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="OperationName"/>.<br/>
        /// По умолчанию заполняется со значением <see cref="OperationNameInfo.Code"/> = <see cref="CIS.EDM.Models.V5_03.Buyer.Reference.OperationNameCode.Accepted"/>.
        /// </remarks>
        /// <value><b>КодСодОпер</b> - сокращенное наименование (код) элемента.</value>
        public OperationNameInfo OperationNameInfo { get; set; } = new OperationNameInfo { Code = Reference.OperationNameCode.Accepted };

        /// <summary>
        /// Сведения о лице, принявшем товары (груз).
        /// </summary>
        /// <value><b>СвЛицПрин</b> - сокращенное наименование (код) элемента.</value>
        public ReceiverPerson ReceiverPerson { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{(!String.IsNullOrEmpty(OperationName) ? OperationName : OperationNameInfo.ToString())}.";
    }
}
