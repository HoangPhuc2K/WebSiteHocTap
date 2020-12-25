using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class RolesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name Roles")]
        public string Name { get; set; }
        public ICollection<UserModel> User { get; set;}
        public bool Status { get; set; }

        public RolesModel()
        {
            Status = true;
        }
    }
}
