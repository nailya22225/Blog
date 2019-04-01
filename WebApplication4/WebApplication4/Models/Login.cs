using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Login
    {
        //[Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Password { get; set; }
    }
}
