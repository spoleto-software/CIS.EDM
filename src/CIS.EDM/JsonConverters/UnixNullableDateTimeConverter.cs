using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CIS.EDM.JsonConverters
{
    public class UnixNullableDateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            return DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64()).LocalDateTime;
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value == null)
                writer.WriteNullValue();
            else
                writer.WriteNumberValue(new DateTimeOffset(value.Value).ToUnixTimeSeconds());
        }
    }
}
