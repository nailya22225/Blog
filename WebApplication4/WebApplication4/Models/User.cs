using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [StringLength(8, MinimumLength =5, ErrorMessage ="Длина строки от 5 до 8 символов")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Password { get; set; }

        [Display(Name = "Количество публикаций")]
        public int NumberOfPublication { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Возраст")]
        public int Years { get; set; }
    }
}
