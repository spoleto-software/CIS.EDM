namespace CIS.EDM.Providers
{
    /// <summary>
    /// Настройки провайдера ЭДО.
    /// </summary>
    public interface IEdmOption
    {
        /// <summary>
        /// Адрес сервиса.
        /// </summary>
        string ServiceUrl { get; set; }

		/// <summary>
		/// Публичный отпечаток сертификата.
		/// </summary>
		string CertificateThumbprint { get; set; }

        /// <summary>
        /// Валидация настроек (проверка, что указаны все обязательные параметры).
        /// Если не указан какой-либо из обязательных параметров, то будет сгенерировано исключение типа <see cref="System.ArgumentNullException"/>.
        /// </summary>
        void Validate();
    }
}
