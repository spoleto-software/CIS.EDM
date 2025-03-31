using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Сведения об операторе электронного документооборота отправителя файла обмена счета-фактуры.
    /// </summary>
    /// <remarks>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/a1a80de58b2ae5c70022162f5350ec54ae5cfae4/">Информация продавца.</see><br/>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/15d3bdcafb5f8941543b641722ad831b62fba547/">Информация покупателя.</see>
    /// </remarks>
    /// <value><b>СвОЭДОтпр</b> - сокращенное наименование (код) элемента.</value>
    public record EdmOperator
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        /// <value><b>НаимОрг</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// ИНН.
        /// </summary>
        /// <value><b>ИННЮЛ</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string Inn { get; set; }

        /// <summary>
        /// Идентификатор оператора электронного документооборота отправителя файла обмена счета-фактуры (информации продавца/покупателя).
        /// </summary>
        /// <remarks>
        /// Идентификатор оператора ЭДО СФ, услугами которого пользуется покупатель (продавец), символьный трехзначный код. В значении идентификатора допускаются символы латинского алфавита A - Z, a - z, цифры 0 - 9, знаки "@", ".", "-". Значение идентификатора регистронезависимо. При включении оператора ЭДО СФ в сеть доверенных операторов ЭДО СФ ФНС России, идентификатор присваивается Федеральной налоговой службой
        /// </remarks>
        /// <value><b>ИдЭДО</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public string OperatorId { get; set; }

        /// <summary>
        /// Текстовое представление объекта.
        /// </summary>
        public override string ToString() => $"{nameof(OperatorId)}: {OperatorId}. {nameof(Name)}: {Name}.";
    }
}