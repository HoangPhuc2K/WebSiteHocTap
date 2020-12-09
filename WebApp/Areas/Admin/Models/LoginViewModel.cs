using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Remember { get; set; }
        public string RequestPath { get; set; }
    }
}
