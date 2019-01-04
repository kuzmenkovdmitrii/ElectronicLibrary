using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Policy;
using ElLib.Common.Entity;

namespace ElLib.Web.Models
{
    public class CreateBookModel
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Name { get; set; }

        [Display(Name = "Категории")]
        [Required(ErrorMessage = "Поле категории не может быть пустым")]
        public int[] Categories { get; set; }

        [Display(Name = "Авторы")]
        [Required(ErrorMessage = "Поле авторы не может быть пустым")]
        public int[] Authors { get; set; }

        [Display(Name = "Язык")]
        [Required(ErrorMessage = "Поле язык публикации не может быть пустым")]
        public int Language { get; set; }

        [Display(Name = "Издательсва")]
        [Required(ErrorMessage = "Поле издательства не может быть пустым")]
        public int[] Publishings { get; set; }

        public string File { get; set; }

        public string Picture { get; set; }
    }
}