using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PostModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nhập Đầy Đủ Thông Tin")]
        [StringLength(maximumLength: 200, ErrorMessage = "Độ Dài Phải Không Quá 200 Ký Tự", MinimumLength = 16)]
        [Display(Name = "Tựa Đề")]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 300, ErrorMessage = "Độ Dài Phải Không Quá 300 Ký Tự", MinimumLength = 16)]
        [Display(Name = "Mô Tả")]
        public string Descripsion { get; set; }

        [Display(Name = "Nội Dung")]
        public string Content { get; set; }

        [Display(Name = "Mã Học Sinh")]
        public int IdStudent { get; set; }
        [ForeignKey("IdStudent")]

        public virtual StudentModel Student { get; set; }

    }
}
