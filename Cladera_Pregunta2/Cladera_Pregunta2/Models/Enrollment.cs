using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cladera_Pregunta2.Models
{
    public enum CategoryType 
    {
        A= 10,
        B = 20,
        C=30,
        D = 40,
        E =50
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        //[Range(1,99999999999)]
        //[Required(ErrorMessage = "You must enter the field {0}")]
        public int CourseID { get; set; }

        [Range(1,99999999999)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "")]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public CategoryType Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}