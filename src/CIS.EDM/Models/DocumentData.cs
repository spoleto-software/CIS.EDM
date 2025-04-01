using System.Text;

namespace CIS.EDM.Models
{
    public record DocumentData
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public Encoding FileEncoding { get; set; }
    }
}
