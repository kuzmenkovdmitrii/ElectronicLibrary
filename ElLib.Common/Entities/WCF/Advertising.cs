using System.Security.Policy;

namespace ElLib.Common.Entities.WCF
{
    public class Advertising
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Url Url { get; set; }
        public Url Picture { get; set; }
    }
}
