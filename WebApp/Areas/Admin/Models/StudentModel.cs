using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class StudentModel
    {
        public int IdStudent { get; set; }

        [Required(ErrorMessage = "Nhập Đầy Đủ Thông Tin")]
        [StringLength(maximumLength: 50, ErrorMessage = "Độ Dài Không Quá 200 Ký Tự", MinimumLength = 8)]
        [Display(Name = "Tên Tài Khoản")]
        public string AccountName { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "Mật Khẩu Dài Hơn 8 Ký Tự", MinimumLength = 8)]
        [Display(Name = "Mật Khẩu")]
        public string AccountPassword { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "Mật Khẩu Dài Hơn 8 Ký Tự", MinimumLength = 8)]
        [Display(Name = "Họ Và Tên")]
        public string FullName { get; set; }

        [EmailAddress(ErrorMessage = "Vui Lòng Nhập Vào 1 E-Mail Hợp Lệ")]
        [StringLength(maximumLength: 300, MinimumLength = 8)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [StringLength(maximumLength: 300, ErrorMessage = "Mật Khẩu Dài Hơn 8 Ký Tự", MinimumLength = 8)]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }

        public ICollection<PostModel> posts { get; set; }

    }
}