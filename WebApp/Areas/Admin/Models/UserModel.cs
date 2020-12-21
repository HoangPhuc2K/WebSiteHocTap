﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Models
{
    public class UserModel
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nhập Đầy Đủ Thông Tin")]
        [StringLength(maximumLength:200, ErrorMessage = "Độ dài không phù hợp", MinimumLength = 8)]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [StringLength(maximumLength:200,ErrorMessage ="Độ dài không phù hợp",MinimumLength = 8)]
        [Display(Name = "Acount Password")]
        public string AccountPassword { get; set; }

        public string Img { get; set; }

        public int IdRoles { get; set; }
        [ForeignKey("IdRoles")]
        public virtual RolesModel Roles { get; set; }
        public virtual AdminModel AdminModel { get; set; }
        public virtual AdminForumModel AdminForum { get; set; }
        public virtual StudentModel StudentModel { get; set; }
        public virtual CoachModel Coach { get; set; }
    }
}
