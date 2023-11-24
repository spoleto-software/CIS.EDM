using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CIS.EDM.Extensions
{
	public static class HttpExtension
	{
		public static void ConfigureRequestMessage(this HttpRequestMessage requestMessage, bool isZipResponse = false)
		{
			requestMessage.Headers.Accept.Clear();

			var contentType = isZipResponse ? ContentType.Zip : DefaultSettings.ContentType;
			requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

			requestMessage.Headers.AcceptCharset.ParseAdd(DefaultSettings.Charset);
		}

		public static void ConfigureHttpClient(this HttpClient client)
		{
			client.Timeout = new TimeSpan(0, 0, 5, 0);
		}
	}
}
