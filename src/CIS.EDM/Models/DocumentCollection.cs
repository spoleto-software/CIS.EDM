using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CIS.EDM.Models
{
	public record DocumentCollection
	{
		/// <summary>
		/// Информация о последнем документе
		/// </summary>
		[JsonPropertyName("items")]
		public List<Document> Items { get; set; }

		/// <summary>
		/// Признак наличия следующей страницы
		/// </summary>
		[JsonPropertyName("has_next_page")]
		public bool HasNextPage { get; set; }

		/// <summary>
		/// Общее число документов
		/// </summary>
		[JsonIgnore]
		public int Count => Items?.Count ?? 0;

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		public override string ToString() => $"Count: {Count}";
	}
}
