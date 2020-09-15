using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cladera_Pregunta2.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain betwen {2} and {1} characters  ", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Title { get; set; }

        [Range(1, 99999)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public int Credits { get; set; }

        [Range(1, 99999)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public int DepartmentID { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}