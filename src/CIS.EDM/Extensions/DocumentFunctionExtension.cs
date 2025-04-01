using CIS.EDM.Models.Reference;

namespace CIS.EDM.Extensions
{
    /// <summary>
    /// Расширения для функции документа.
    /// </summary>
    public static class DocumentFunctionExtension
    {
        /// <summary>
        /// Возвращает наименование первичного документа согласно функции документа.
        /// </summary>
        /// <remarks>
        /// При Функция = СЧФ не формируется.
        /// При Функция = СЧФДОП принимает значение "Счет-фактура и документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)".
        /// При Функция = ДОП самостоятельно установленное наименование документа
        /// или "Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)"(по умолчанию)
        /// </remarks>
        /// <returns>Наименование первичного документа</returns>
        public static string GetDocumentName(this UniversalTransferDocumentFunction documentFunction)
        {
            return documentFunction switch
            {
                UniversalTransferDocumentFunction.СЧФ => null,
                UniversalTransferDocumentFunction.СЧФДОП => "Счет-фактура и документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)",
                UniversalTransferDocumentFunction.ДОП => "Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)",
                _ => null
            };
        }

        /// <summary>
        /// Возвращает наименование документа по факту хозяйственной жизни согласно функции документа.
        /// </summary>
        /// <returns></returns>
        public static string GetDocumentEconomicName(this UniversalTransferDocumentFunction documentFunction)
        {
            return documentFunction switch
            {
                UniversalTransferDocumentFunction.СЧФ => null,
                UniversalTransferDocumentFunction.СЧФДОП
                or UniversalTransferDocumentFunction.ДОП => "Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)",
                _ => null,
            };
        }
    }
}
