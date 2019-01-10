using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class EditUserPasswordModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Старый пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле пароль не может быть пустым")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Пароль не может быть менее 6 символов")]
        public string OldPassword { get; set; }

        [Display(Name = "Новый пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле пароль не может быть пустым")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Пароль не может быть менее 6 символов")]
        public string NewPassword { get; set; }

        [Display(Name = "Повторите новый пароль")]
        [Required(ErrorMessage = "Повторите пароль")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}