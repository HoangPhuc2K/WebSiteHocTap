using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class CourseModel
    {
        [Key]
        public int IdCourse { set; get; }

        [Required]
        [Display(Name = "Title")]
        [StringLength(maximumLength: 200, ErrorMessage = "Độ dài không phù hợp")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(maximumLength: 300, ErrorMessage = "Độ dài không phù hợp")]
        public string Description { get; set; }

        public ICollection<LessonModel> Lesson { get; set; }

    }
}
    