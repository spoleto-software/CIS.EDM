using CIS.EDM.Models.Common;

namespace CIS.EDM.Models.Seller
{
    /// <summary>
    /// <see href="http://www.consultant.ru/document/cons_doc_LAW_316356/798fbbf5ce2fcd4aceb36ed5066c5ad9428e8f79/#dst101491">Сведения об индивидуальном предпринимателе.</see>
    /// </summary>
    /// <value><b>ИП</b> - сокращенное наименование (код) элемента.</value>
    public record IndividualEntrepreneur : Person
    {
        /// <summary>
        /// ИНН
        /// </summary>
        /// <remarks>
        /// Обязателен при отсутствии <see cref="IsHyphenInn"/>.
        /// </remarks>
        /// <value><b>ИННФЛ</b> - сокращенное наименование (код) элемента.</value>
        public string Inn { get; set; }

        /// <summary>
        /// ИНН при составлении документа с Функция=СЧФ или Функция=СЧФДОП налоговым агентом,
        /// указанным в пунктах 2 и 3 статьи 161 НК РФ, в части информации о продавце/грузоотправителе.
        /// </summary>
        /// <remarks>
        /// Принимает значение "-" (дефис) (визуализируется как прочерк).
        /// <para>При наличии <see cref="Inn"/> не формируется.</para>
        /// Обязателен при отсутствии <see cref="Inn"/>.
        /// </remarks>
        /// <value><b>ДефИННФЛ</b> - сокращенное наименование (код) элемента.</value>
        public bool IsHyphenInn => string.IsNullOrEmpty(Inn);

        /// <summary>
        /// Реквизиты свидетельства о государственной регистрации индивидуального предпринимателя.
        /// </summary>
        /// <remarks>
        /// Обязателен для случаев подписания счета-фактуры непосредственно продавцом.
        /// </remarks>
        /// <value><b>СвГосРегИП</b> - сокращенное наименование (код) элемента.</value>
        public string IndividualEntrepreneurRegistrationCertificate { get; set; }

        /// <summary>
        /// Иные сведения, идентифицирующие физическое лицо.
        /// </summary>
        /// <value><b>ИныеСвед</b> - сокращенное наименование (код) элемента.</value>
        public string OtherInfo { get; set; }
    }
}
