using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ElLib.Common.Entity;

namespace ElLib.Web.Models
{
    public class EditPublishingModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Не верная длина названия")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        public Address Address { get; set; }
    }
}