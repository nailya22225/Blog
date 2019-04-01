using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Blog
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Поле не должно быть пустым")]
        [Display(Name ="Текст")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Заголовок")]
        public string Headline { get; set; }
        [Display(Name = "Открыто для всех")]
        public bool IsOpen { get; set; }
        [ScaffoldColumn(false)]
        public int UserId { get; set; }
    }
}
