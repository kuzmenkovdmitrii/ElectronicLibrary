using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class BookCategoryModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}