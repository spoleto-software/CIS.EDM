using System.Text;

namespace CIS.EDM
{
    public static class DefaultSettings
    {
        public const string ContentType = CIS.EDM.ContentType.ApplicationJson;
        public const string Charset = "utf-8";
        public static readonly Encoding Encoding = Encoding.GetEncoding(Charset);
    }
}
