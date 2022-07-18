using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CIS.EDM.Models
{
    public class DocumentCollection
    {
        /// <summary>
        /// Информация о последнем документе
        /// </summary>
        [JsonPropertyName("items")]
        public List<Document> Items { get; set; }

        /// <summary>
        /// Общее число документов
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString() => $"Count: {Count}";
    }
}
