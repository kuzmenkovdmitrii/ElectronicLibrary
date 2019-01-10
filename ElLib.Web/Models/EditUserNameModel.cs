using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class EditUserNameModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Поле логин не может быть пустым")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Не верная длина")]
        [Remote("CheckUserName", "Auth", ErrorMessage = "Пользователь с таким названием уже существует")]
        public string UserName { get; set; }
    }
}