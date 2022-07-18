using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Web;

namespace CIS.EDM.Helpers
{
    /// <summary>
    /// Http helper.
    /// </summary>
    public static class HttpHelper
    {
        private static readonly JavaScriptEncoder _cyrillicEncoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
        private static readonly JsonSerializerOptions _defaultOptions;

        static HttpHelper()
        {
            _defaultOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                Encoder = _cyrillicEncoder
            };

            //_defaultOptions.Converters.Add(new JsonStringEnumConverter());
        }

        /// <summary>
        /// Serialize object to Json format
        /// </summary>
        public static string ToJson<T>(T body, JsonSerializerOptions options = null)
        {
            options ??= _defaultOptions;

            var bodyJson = JsonSerializer.Serialize(body, options);

            return bodyJson;
        }

        /// <summary>
        /// Deserialize object from Json format
        /// </summary>
        public static T FromJson<T>(string bodyJson, JsonSerializerOptions options = null)
        {
            options ??= _defaultOptions;

            var body = JsonSerializer.Deserialize<T>(bodyJson, options);
            return body;
        }

        /// <summary>
        /// Serialize object to Json format
        /// </summary>
        public static async Task ToJsonStreamAsync<T>(T body, Stream streamTo, JsonSerializerOptions options = null)
        {
            options ??= _defaultOptions;

            await JsonSerializer.SerializeAsync(streamTo, body, options).ConfigureAwait(false);
        }

        /// <summary>
        /// Deserialize object from Json format
        /// </summary>
        public static async Task<T> FromJsonStreamAsync<T>(Stream jsonStream, JsonSerializerOptions options = null)
        {
            options ??= _defaultOptions;
            var body = await JsonSerializer.DeserializeAsync<T>(jsonStream, options).ConfigureAwait(false);

            return body;
        }

        /// <summary>
        /// Serialize object to Json bytes
        /// </summary>
        public static byte[] ToJsonBytes<T>(T body, JsonSerializerOptions options = null)
        {
            options ??= _defaultOptions;

            var bytes = JsonSerializer.SerializeToUtf8Bytes(body, options);

            return bytes;
        }

        /// <summary>
        /// Deserialize object from Json bytes.
        /// </summary>
        public static T FromJsonBytes<T>(byte[] bodyJson, JsonSerializerOptions options = null)
        {
            options ??= _defaultOptions;

            var body = JsonSerializer.Deserialize<T>(bodyJson, options);
            return body;
        }

        /// <summary>
        /// Converts to query string.
        /// </summary>
        /// <returns></returns>
        public static string ToQueryString<T>(T body, JsonSerializerOptions options = null)
        {
            var bodyJson = ToJson(body, options);
            var dictionaryAsObjectValues = FromJson<Dictionary<string, object>>(bodyJson, options);

            var args = new List<string>();
            foreach (var key in dictionaryAsObjectValues.Keys)
            {
                var jsonValue = (JsonElement)dictionaryAsObjectValues[key];
                var objValue = FlattenJsonValue(jsonValue);
                if (objValue is string str)
                {
                    args.Add($"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(str)}");
                }
                else if (objValue is IEnumerable enumerable)
                {
                    foreach (string item in enumerable)
                    {
                        args.Add($"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(item)}");
                    }
                }
            }

            return string.Join("&", args);
        }

        private static object FlattenJsonValue(JsonElement objValue)
        {
            return objValue.ValueKind switch
            {
                JsonValueKind.String => objValue.GetString(),
                JsonValueKind.Array => objValue.EnumerateArray().Select(x => FlattenJsonValue(x)),
                _ => objValue.GetRawText()
            };
        }

        /// <summary>
        /// Convert string content to Base64 format
        /// </summary>
        public static string ConvertToBase64(string stringToConvert)
            => ConvertToBase64(stringToConvert, DefaultSettings.Encoding);


        /// <summary>
        /// Convert string content to Base64 format
        /// </summary>
        public static string ConvertToBase64(string stringToConvert, Encoding encoding)
            => Convert.ToBase64String(encoding.GetBytes(stringToConvert));

        /// <summary>
        /// Convert Base64-encoded string to UTF8-string
        /// </summary>
        public static string ConvertFromBase64(string base64EncodedData)
            => ConvertFromBase64(base64EncodedData, DefaultSettings.Encoding);


        /// <summary>
        /// Convert Base64-encoded string to UTF8-string
        /// </summary>
        public static string ConvertFromBase64(string base64EncodedData, Encoding encoding)
            => encoding.GetString(Convert.FromBase64String(base64EncodedData));
    }
}
