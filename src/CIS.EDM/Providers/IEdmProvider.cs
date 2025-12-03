using CIS.EDM.Models;
using System;
using System.Threading.Tasks;

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
		ResultInfo PostUniversalTransferDocument(T settings, Models.V5_01.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false)
			=> PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№820".
		/// Метод загрузки файла информации продавца УПД согласно приказа 820 от 19.12.2018 № ММВ-7-15/820@ в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		Task<ResultInfo> PostUniversalTransferDocumentAsync(T settings, Models.V5_01.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false);

		/// <summary>
		/// Отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		ResultInfo PostUniversalTransferDocument(T settings, Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false)
			=> PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		Task<ResultInfo> PostUniversalTransferDocumentAsync(T settings, Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false);

		/// <summary>
		/// Добавление извещения о получении к документу в формате приказа "№820".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(T settings, Models.V5_01.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу в формате приказа "№820".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(T settings, Models.V5_01.Buyer.BuyerUniversalTransferDocument dataContract);

		/// <summary>
		/// Добавление извещения о получении к документу в формате приказа "№970".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(T settings, Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу в формате приказа "№970".
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(T settings, Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract);

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

		/// <summary>
		/// Получение информации из файла продавца
		/// </summary>
		/// <param name="settings">Настройки для API</param>
		/// <param name="sellerDocumentId">Идентификатор файла продавца</param>
		/// <returns>Информации из файла продавца</returns>
		SellerDocumentInfo GetSellerDocumentInfo(T settings, string sellerDocumentId)
			=> GetSellerDocumentInfoAsync(settings, sellerDocumentId).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное получение информации из файла продавца
		/// </summary>
		/// <param name="settings">Настройки для API</param>
		/// <param name="sellerDocumentId">Идентификатор файла продавца</param>
		/// <returns>Информации из файла продавца</returns>
		Task<SellerDocumentInfo> GetSellerDocumentInfoAsync(T settings, string sellerDocumentId);

		Task<ResultInfo> IEdmProvider.PostUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_01.Seller.SellerUniversalTransferDocument dataContract, bool isDraft)
			=> PostUniversalTransferDocumentAsync((T)settings, dataContract, isDraft);

		Task<ResultInfo> IEdmProvider.PostUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft)
			=> PostUniversalTransferDocumentAsync((T)settings, dataContract, isDraft);

		Task<ResultInfo> IEdmProvider.ReceiptUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_01.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync((T)settings, dataContract);

		Task<ResultInfo> IEdmProvider.ReceiptUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync((T)settings, dataContract);

		Task<string> IEdmProvider.GetIncomingDocumentAsync(IEdmOption settings, string documentId)
			=> GetIncomingDocumentAsync((T)settings, documentId);

		Task<DocumentCollection> IEdmProvider.GetIncomingDocumentListAsync(IEdmOption settings, DocumentCollectionSearchModel searchModel)
			=> GetIncomingDocumentListAsync((T)settings, searchModel);

		Task<string> IEdmProvider.GetOutgoingDocumentAsync(IEdmOption settings, string documentId)
			=> GetOutgoingDocumentAsync((T)settings, documentId);

		Task<DocumentCollection> IEdmProvider.GetOutgoingDocumentListAsync(IEdmOption settings, DocumentCollectionSearchModel searchModel)
			=> GetOutgoingDocumentListAsync((T)settings, searchModel);

		Task<SellerDocumentInfo> IEdmProvider.GetSellerDocumentInfoAsync(IEdmOption settings, string sellerDocumentId)
			=> GetSellerDocumentInfoAsync((T)settings, sellerDocumentId);
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
		ResultInfo PostUniversalTransferDocument(IEdmOption settings, Models.V5_01.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false)
			=> PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№820".
		/// Метод загрузки файла информации продавца УПД согласно приказа 820 от 19.12.2018 № ММВ-7-15/820@ в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		Task<ResultInfo> PostUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_01.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false);

		/// <summary>
		/// Отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		ResultInfo PostUniversalTransferDocument(IEdmOption settings, Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false)
			=> PostUniversalTransferDocumentAsync(settings, dataContract, isDraft).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронная отправка универсального передаточного документа (УПД) в формате приказа "№970".
		/// Метод загрузки файла информации продавца УПД согласно приказа ФНС России от 19.12.2023 N ЕД-7-26/970@ (ред. от 15.11.2024) в формате XML
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация продавца.</param>
		/// <param name="isDraft">Создать только черновник. Не отправлять документ получателю.</param>
		/// <returns>Информация об отправке сообщения.</returns>
		Task<ResultInfo> PostUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_03.Seller.SellerUniversalTransferDocument dataContract, bool isDraft = false);



		/// <summary>
		/// Добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(IEdmOption settings, Models.V5_01.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_01.Buyer.BuyerUniversalTransferDocument dataContract);

		/// <summary>
		/// Добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		ResultInfo ReceiptUniversalTransferDocument(IEdmOption settings, Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract)
			=> ReceiptUniversalTransferDocumentAsync(settings, dataContract).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное добавление извещения о получении к документу
		/// </summary>
		/// <param name="settings">Настройки для API.</param>
		/// <param name="dataContract">Информация покупателя.</param>
		/// <returns>Идентификатор созданного извещения о получении</returns>
		Task<ResultInfo> ReceiptUniversalTransferDocumentAsync(IEdmOption settings, Models.V5_03.Buyer.BuyerUniversalTransferDocument dataContract);

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

		/// <summary>
		/// Получение информации из файла продавца
		/// </summary>
		/// <param name="settings">Настройки для API</param>
		/// <param name="sellerDocumentId">Идентификатор файла продавца</param>
		/// <returns>Информации из файла продавца</returns>
		SellerDocumentInfo GetSellerDocumentInfo(IEdmOption settings, string sellerDocumentId)
			=> GetSellerDocumentInfoAsync(settings, sellerDocumentId).GetAwaiter().GetResult();

		/// <summary>
		/// Асинхронное получение информации из файла продавца
		/// </summary>
		/// <param name="settings">Настройки для API</param>
		/// <param name="sellerDocumentId">Идентификатор файла продавца</param>
		/// <returns>Информации из файла продавца</returns>
		Task<SellerDocumentInfo> GetSellerDocumentInfoAsync(IEdmOption settings, string sellerDocumentId);
	}
}
