﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.EDM.Models.V5_03
{
	/// <summary>
	/// Сведения о доверенности в электронной форме в машиночитаемом виде, используемой для подтверждения полномочий представителя (СвДоверЭл)
	/// </summary>
	public record ElectronicPoAInfo
	{
		/// <summary>
		/// Единый регистрационный номер доверенности.
		/// </summary>
		/// <value><b>НомДовер</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public Guid RegistrationNumber { get; set; }

		/// <summary>
		/// Дата совершения (выдачи) доверенности.
		/// </summary>
		/// <value><b>ДатаВыдДовер</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public DateTime IssueDate { get; set; }

		/// <summary>
		/// Внутренний номер доверенности.
		/// </summary>
		/// <remarks>
		/// При отсутствии номера принимает значение: без номера (б/н)
		/// </remarks>
		/// <value><b>ВнНомДовер</b> - сокращенное наименование (код) элемента.</value>
		public string InternalNumber { get; set; }

		/// <summary>
		/// Дата внутренней регистрации доверенности.
		/// </summary>
		/// <value><b>ДатаВнРегДовер</b> - сокращенное наименование (код) элемента.</value>
		public DateTime? InternalRegistrationDate { get; set; }

		/// <summary>
		/// Идентифицирующая информация об информационной системе, в которой осуществляется хранение доверенности, необходимая для запроса информации из информационной системы.
		/// </summary>
		/// <value><b>ИдСистХран</b> - сокращенное наименование (код) элемента.</value>
		[Required]
		public string SystemIdentification { get; set; }

		/// <summary>
		/// Сведения в формате URL об информационной системе, которая предоставляет техническую возможность получения информации о доверенности.
		/// </summary>
		/// <value><b>УРЛСист</b> - сокращенное наименование (код) элемента.</value>
		public string SystemURL { get; set; }
	}
}