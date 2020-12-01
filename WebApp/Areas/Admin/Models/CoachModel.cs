using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class CoachModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nhập Đầy Đủ Thông Tin")]
        [StringLength(maximumLength: 200, ErrorMessage = "Độ Dài Phải Qua 200 Ký Tự", MinimumLength = 16)]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [StringLength(maximumLength: 200, ErrorMessage = "Độ dài không phù hợp", MinimumLength = 12)]
        [Display(Name = "Acount Password")]
        public string AccountPassword { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(maximumLength: 200, ErrorMessage = "Độ dài không phù hợp")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(maximumLength: 1000, ErrorMessage = "Độ dài không phù hợp", MinimumLength = 16)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(maximumLength: 10, ErrorMessage = "Độ dài không phù hợp", MinimumLength = 10)]
        public string Phone { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual UserModel User { get; set; }

        public ICollection<LessonModel> Lesson { get; set; }
    }
}
