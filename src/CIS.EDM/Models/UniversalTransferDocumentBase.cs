using System;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Reference;
using CIS.EDM.Models.Seller;

namespace CIS.EDM.Models
{
    /// <summary>
    /// Базовый класс для УПД.
    /// </summary>
    public abstract class UniversalTransferDocumentBase
    {
        private TransferDocumentType? _manualTransferDocumentType;
        private string _fileId;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public UniversalTransferDocumentBase()
        {
            DateCreation = DateTime.UtcNow;
        }

        /// <summary>
        /// Тип УПД.<br/>
        /// Общий случай либо товары, подлежащие маркировке либо прослеживаемости.
        /// </summary>
        /// <remarks>
        /// Если не передать, то заполнится автоматом.
        /// </remarks>
        public TransferDocumentType TransferDocumentType
        {
            get => _manualTransferDocumentType ?? GetTransferDocumentType();
            set => _manualTransferDocumentType = value;
        }

        /// <summary>
        /// Идентификатор файла.
        /// </summary>
        /// <remarks>
        /// Содержит (повторяет) имя сформированного файла (без расширения).<br/>
        /// Если не передать, то заполнится автоматом.
        /// </remarks>
        /// <value><b>ИдФайл</b> - сокращенное наименование (код) элемента.</value>
        public string FileId
        {
            get => _fileId ??= GetFileId();
            set => _fileId = value;
        }

        /// <summary>
        /// Версия формата.
        /// </summary>
        /// <remarks>
        /// Принимает значение: 5.01.
        /// </remarks>
        /// <value><b>ВерсФорм</b> - сокращенное наименование (код) элемента.</value>
        public string FormatVersion { get; set; } = Constants.FormatVersion;

        /// <summary>
        /// Версия программы, с помощью которой сформирован файл.
        /// </summary>
        /// <value><b>ВерсПрог</b> - сокращенное наименование (код) элемента.</value>
        public string ApplicationCreator { get; set; } = Constants.AppVersion;

        /// <summary>
        /// Отправитель УПД.
        /// </summary>
        /// <value><b>ИдОтпр</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public EdmParticipant SenderEdmParticipant { get; set; }

        /// <summary>
        /// Получатель УПД.
        /// </summary>
        /// <value><b>ИдПол</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public EdmParticipant RecipientEdmParticipant { get; set; }

        /// <summary>
        /// Оператор ЭДО.
        /// </summary>
        /// <value><b>СвОЭДОтпр</b> - сокращенное наименование (код) элемента.</value>
        public EdmOperator EdmOperator { get; set; }

        /// <summary>
        /// Дата создания файла обмена
        /// </summary>
        /// <value><b>ДатаИнфПр, ВремИнфПр</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public DateTime DateCreation { get; }

        /// <summary>
        /// Экономический субъект - составитель файла обмена счета-фактуры (информации продавца).
        /// </summary>
        /// <value><b>НаимЭконСубСост</b> - сокращенное наименование (код) элемента.</value>
        [Required]
        public Organization DocumentCreator { get; set; }

        /// <summary>
        /// Получение типа УПД.
        /// </summary>
        protected abstract TransferDocumentType GetTransferDocumentType();

        /// <summary>
        /// Получение идентификатора файла.
        /// </summary>
        protected abstract string GetFileId();
    }
}