using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Labb4_uppg2.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        [DisplayName("Kursnamn")]
        public string CourseName { get; set; }
        [DisplayName("Betyg")]
        public string CourseGrade { get; set; }
    }
}