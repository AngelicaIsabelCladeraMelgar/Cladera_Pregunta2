using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cladera_Pregunta2.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain betwen {2} and {1} characters  ", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name ="Nombre")]
        public string FirstMindName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment>  Enrollments{ get; set; }


    }
}