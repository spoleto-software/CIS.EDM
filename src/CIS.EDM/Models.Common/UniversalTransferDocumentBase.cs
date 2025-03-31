using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CIS.EDM.Models.Common.Reference;
using CIS.EDM.Models.Seller;

namespace CIS.EDM.Models.Common
{
    /// <summary>
    /// Базовый класс для УПД.
    /// </summary>
    public abstract record UniversalTransferDocumentBase
    {
        private List<TransferDocumentType> _manualTransferDocumentTypes;
        private string _fileId;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public UniversalTransferDocumentBase()
        {
            DateCreation = DateTime.UtcNow;
        }

        /// <summary>
        /// Тип участника.
        /// </summary>
		public abstract PartyType PartyType { get; }

		/// <summary>
		/// Типы УПД.<br/>
		/// Общий случай либо товары, подлежащие маркировке, прослеживаемости.
		/// </summary>
		/// <remarks>
		/// Если не передать, то заполнится автоматом.
		/// </remarks>
		public List<TransferDocumentType> TransferDocumentTypes
        {
            get => _manualTransferDocumentTypes ??= GetTransferDocumentTypes();
            set => _manualTransferDocumentTypes = value;
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
        /// <value><b>ВерсФорм</b> - сокращенное наименование (код) элемента.</value>
        public abstract string FormatVersion { get; set; }

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
        /// Получение типа УПД.
        /// </summary>
        protected abstract List<TransferDocumentType> GetTransferDocumentTypes();

        /// <summary>
        /// Получение идентификатора файла.
        /// </summary>
        protected abstract string GetFileId();
    }
}