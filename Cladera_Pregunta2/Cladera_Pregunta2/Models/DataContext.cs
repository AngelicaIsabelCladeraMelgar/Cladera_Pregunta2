using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cladera_Pregunta2.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Cladera_Pregunta2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<Cladera_Pregunta2.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<Cladera_Pregunta2.Models.Course> Courses { get; set; }
    }
}