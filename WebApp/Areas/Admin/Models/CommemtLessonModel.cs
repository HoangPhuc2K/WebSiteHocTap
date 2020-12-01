﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class CommemtLessonModel
    {
        [Key]
        public int IdCommentLesson { get; set; }
        [Required]
        [StringLength(maximumLength: 300, ErrorMessage = "Độ Dài khong Vượt Qúa 300 Ký Tự", MinimumLength = 16)]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }
        public int IdLesson { get; set; }
        [ForeignKey("IdLesson")]
        public virtual LessonModel Lesson { get; set; }

    }
}

