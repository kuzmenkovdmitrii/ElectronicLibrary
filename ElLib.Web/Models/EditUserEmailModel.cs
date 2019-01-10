using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class EditUserEmailModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Поле Email не может быть пустым")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Неверно введен Email")]
        [Remote("CheckEmail", "Auth", ErrorMessage = "Пользователь с таким email уже существует")]
        public string Email { get; set; }
    }
}