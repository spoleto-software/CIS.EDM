//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;

//namespace CIS.EDM.JsonConverters
//{
//    public class IntEnumConverter<T> : JsonConverter<T> where T : Enum
//    {
//        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//        {
//            int intValue;
//            if (reader.TokenType == JsonTokenType.String)
//                intValue = int.Parse(reader.GetString());
//            else if (reader.TokenType == JsonTokenType.Number)
//                intValue = (int)reader.GetDecimal();
//            else
//                throw new NotSupportedException();

//            if (!Enum.IsDefined(value)) throw new Exception($"Value {value} is invalid!");
//            return value;
//            return (T)intValue;
//        }

//        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
//        {
//            writer.WriteNumberValue((int)value);
//        }
//    }
//}
