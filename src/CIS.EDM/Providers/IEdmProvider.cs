using System;
using System.Threading.Tasks;
using CIS.EDM.Models;
using CIS.EDM.Models.Buyer;
using CIS.EDM.Models.Seller;

namespace CIS.EDM.Providers
{
    /// <summary>
    /// Провайдер ЭДО с типизированными настройками.
    /// </summary>
    /// <typeparam name="T">Тип настроек для конкретного провайдера.</typeparam>
    public interface IEdmProvider<T> : IEdmProvider where T : IEdmOption
    {
        /// <summary>
        /// Тип настроек провайдера.
        /// </summary>
        Type IEdmProvider.OptionType => typeof(T);

        /// <summary>
        /// Отправка универсального передаточного документа (УПД) в формате приказа "№820".
        /// Метод загрузки файла информации продавца УПД согласно приказа 820 от 19.12.2018 № ММВ-7-15/820@ в формате XML
        /// </summary>
        /// <param name="settings">Настройки для API.</param>
        /// <param name="dataContract">Информация продавца.</param>
        /// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
        /// <returns>Информация об отправке сообщения.</returns>
        ResultInfo PostUniversalTransferDocument(T settings, SellerUniversalTransferDocument dataContract, bool isDraft = false)
            => PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№820".
        /// Метод загрузки файла информации продавца УПД согласно приказа 820 от 19.12.2018 № ММВ-7-15/820@ в формате XML
        /// </summary>
        /// <param name="settings">Настройки для API.</param>
        /// <param name="dataContract">Информация продавца.</param>
        /// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
        /// <returns>Информация об отправке сообщения.</returns>
        Task<ResultInfo> PostUniversalTransferDocumentAsync(T settings, SellerUniversalTransferDocument dataContract, bool isDraft = false);

		/// <summary>
		/// Отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		ResultInfo PostUniversalTransferDocument(T settings, CIS.EDM.Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false)
			=> PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		Task<ResultInfo> PostUniversalTransferDocumentAsync(T settings, CIS.EDM.Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false);

		/// <summary>
		/// Добавление извещения о получении к документу в формате приказа "№820".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(T settings, BuyerUniversalTransferDocument dataContract)
            => ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу в формате приказа "№820".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(T settings, BuyerUniversalTransferDocument dataContract);

		/// <summary>
		/// Добавление извещения о получении к документу в формате приказа "№970".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(T settings, CIS.EDM.Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу в формате приказа "№970".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(T settings, CIS.EDM.Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract);

		/// <summary>
		/// Получение содержимого XML входящего документа
		/// </summary>
		/// <param name="settings">Настройки для API</param>
		/// <param name="documentId">Идентификатор документа</param>
		/// <returns>Содержимое XML входящего документа</returns>
		string GetIncomingDocument(T settings, string documentId)
            => GetIncomingDocumentAsync(settings, documentId).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение содержимого XML входящего документа
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="documentId">Идентификатор документа</param>
        /// <returns>Содержимое XML входящего документа</returns>
        Task<string> GetIncomingDocumentAsync(T settings, string documentId);

        /// <summary>
        /// Получение списка входящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список входящих документов</returns>
        DocumentCollection GetIncomingDocumentList
            (T settings, DocumentCollectionSearchModel searchModel = null)
            => GetIncomingDocumentListAsync(settings, searchModel).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение списка входящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список входящих документов</returns>
        Task<DocumentCollection> GetIncomingDocumentListAsync(T settings, DocumentCollectionSearchModel searchModel = null);

        /// <summary>
        /// Получение содержимого XML исходящего документа
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="documentId">Идентификатор документа</param>
        /// <returns>Содержимое XML исходящего документа</returns>
        string GetOutgoingDocument(T settings, string documentId)
            => GetOutgoingDocumentAsync(settings, documentId).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение содержимого XML исходящего документа
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="documentId">Идентификатор документа</param>
        /// <returns>Содержимое XML исходящего документа</returns>
        Task<string> GetOutgoingDocumentAsync(T settings, string documentId);

        /// <summary>
        /// Получение списка исходящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список исходящих документов</returns>
        DocumentCollection GetOutgoingDocumentList(T settings, DocumentCollectionSearchModel searchModel = null)
            => GetOutgoingDocumentListAsync(settings, searchModel).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение списка исходящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список исходящих документов</returns>
        Task<DocumentCollection> GetOutgoingDocumentListAsync(T settings, DocumentCollectionSearchModel searchModel = null);

        Task<ResultInfo> IEdmProvider.PostUniversalTransferDocumentAsync(IEdmOption settings, SellerUniversalTransferDocument dataContract, bool isDraft)
            => PostUniversalTransferDocumentAsync((T)settings, dataContract, isDraft);

		Task<ResultInfo> IEdmProvider.PostUniversalTransferDocumentAsync(IEdmOption settings, CIS.EDM.Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft)
			=> PostUniversalTransferDocumentAsync((T)settings, dataContract, isDraft);

		Task<ResultInfo> IEdmProvider.ReceiptUniversalTransferDocumentAsync(IEdmOption settings, BuyerUniversalTransferDocument dataContract)
            => ReceiptUniversalTransferDocumentAsync((T)settings, dataContract);

		Task<ResultInfo> IEdmProvider.ReceiptUniversalTransferDocumentAsync(IEdmOption settings, CIS.EDM.Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync((T)settings, dataContract);

		Task<string> IEdmProvider.GetIncomingDocumentAsync(IEdmOption settings, string documentId)
            => GetIncomingDocumentAsync((T)settings, documentId);

        Task<DocumentCollection> IEdmProvider.GetIncomingDocumentListAsync(IEdmOption settings, DocumentCollectionSearchModel searchModel)
            => GetIncomingDocumentListAsync((T)settings, searchModel);

        Task<string> IEdmProvider.GetOutgoingDocumentAsync(IEdmOption settings, string documentId)
            => GetOutgoingDocumentAsync((T)settings, documentId);

        Task<DocumentCollection> IEdmProvider.GetOutgoingDocumentListAsync(IEdmOption settings, DocumentCollectionSearchModel searchModel)
            => GetOutgoingDocumentListAsync((T)settings, searchModel);
    }

    /// <summary>
    /// Провайдер ЭДО.
    /// </summary>
    public interface IEdmProvider
    {
        /// <summary>
        /// Уникальный код провайдера.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Название провайдера для отображения
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Тип настроек провайдера.
        /// </summary>
        Type OptionType { get; }

        /// <summary>
        /// Отправка универсального передаточного документа (УПД) в формате приказа "№820".
        /// Метод загрузки файла информации продавца УПД согласно приказа 820 от 19.12.2018 № ММВ-7-15/820@ в формате XML
        /// </summary>
        /// <param name="settings">Настройки для API.</param>
        /// <param name="dataContract">Информация продавца.</param>
        /// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
        /// <returns>Информация об отправке сообщения.</returns>
        ResultInfo PostUniversalTransferDocument(IEdmOption settings, SellerUniversalTransferDocument dataContract, bool isDraft = false)
            => PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№820".
        /// Метод загрузки файла информации продавца УПД согласно приказа 820 от 19.12.2018 № ММВ-7-15/820@ в формате XML
        /// </summary>
        /// <param name="settings">Настройки для API.</param>
        /// <param name="dataContract">Информация продавца.</param>
        /// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
        /// <returns>Информация об отправке сообщения.</returns>
        Task<ResultInfo> PostUniversalTransferDocumentAsync(IEdmOption settings, SellerUniversalTransferDocument dataContract, bool isDraft = false);

		/// <summary>
		/// Отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		ResultInfo PostUniversalTransferDocument(IEdmOption settings, CIS.EDM.Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false)
			=> PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		Task<ResultInfo> PostUniversalTransferDocumentAsync(IEdmOption settings, CIS.EDM.Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false);



		/// <summary>
		/// Добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(IEdmOption settings, BuyerUniversalTransferDocument dataContract)
            => ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное добавление извещения о получении к документу
        /// </summary>
        /// <param name="settings">Настройки для API.</param>
        /// <param name="dataContract">Информация покупателя.</param>
        /// <returns>Идентификатор созданного извещения о получении</returns>
        Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(IEdmOption settings, BuyerUniversalTransferDocument dataContract);

		/// <summary>
		/// Добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(IEdmOption settings, CIS.EDM.Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(IEdmOption settings, CIS.EDM.Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract);

		/// <summary>
		/// Получение содержимого XML входящего документа
		/// </summary>
		/// <param name="settings">Настройки для API</param>
		/// <param name="documentId">Идентификатор документа</param>
		/// <returns>Содержимое XML входящего документа</returns>
		string GetIncomingDocument(IEdmOption settings, string documentId)
            => GetIncomingDocumentAsync(settings, documentId).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение содержимого XML входящего документа
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="documentId">Идентификатор документа</param>
        /// <returns>Содержимое XML входящего документа</returns>
        Task<string> GetIncomingDocumentAsync(IEdmOption settings, string documentId);

        /// <summary>
        /// Получение списка входящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список входящих документов</returns>
        DocumentCollection GetIncomingDocumentList(IEdmOption settings, DocumentCollectionSearchModel searchModel = null)
            => GetIncomingDocumentListAsync(settings, searchModel).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение списка входящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список входящих документов</returns>
        Task<DocumentCollection> GetIncomingDocumentListAsync(IEdmOption settings, DocumentCollectionSearchModel searchModel = null);

        /// <summary>
        /// Получение содержимого XML исходящего документа
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="documentId">Идентификатор документа</param>
        /// <returns>Содержимое XML исходящего документа</returns>
        string GetOutgoingDocument(IEdmOption settings, string documentId)
            => GetOutgoingDocumentAsync(settings, documentId).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение содержимого XML исходящего документа
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="documentId">Идентификатор документа</param>
        /// <returns>Содержимое XML исходящего документа</returns>
        Task<string> GetOutgoingDocumentAsync(IEdmOption settings, string documentId);

        /// <summary>
        /// Получение списка исходящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список исходящих документов</returns>
        DocumentCollection GetOutgoingDocumentList(IEdmOption settings, DocumentCollectionSearchModel searchModel = null)
            => GetOutgoingDocumentListAsync(settings, searchModel).GetAwaiter().GetResult();

        /// <summary>
        /// Асинхронное получение списка исходящих документов
        /// </summary>
        /// <param name="settings">Настройки для API</param>
        /// <param name="searchModel">Критерии отбора документов</param>
        /// <returns>Список исходящих документов</returns>
        Task<DocumentCollection> GetOutgoingDocumentListAsync(IEdmOption settings, DocumentCollectionSearchModel searchModel = null);
    }
}
