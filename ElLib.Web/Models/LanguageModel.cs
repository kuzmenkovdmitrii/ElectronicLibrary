using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class LanguageModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameRu { get; set; }
    }
}