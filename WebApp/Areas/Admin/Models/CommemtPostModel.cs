﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Areas.Admin.Models
{
    public class CommemtPostModel
    {
        [Key]
        public int IdCommentPost { get; set; }
        [Required]
        [StringLength(maximumLength: 300, ErrorMessage = "Độ Dài Vượt Qúa 300 Ký Tự", MinimumLength = 16)]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }
        public int IdPost { get; set; }
        [ForeignKey("IdPost")]
        public virtual PostModel Post { get; set; }

    }
}
