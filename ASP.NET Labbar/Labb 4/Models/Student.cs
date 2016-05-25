using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb_4.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name  { get; set; }
        public string Lastname { get; set; }
        public int Personnumber { get; set; }
        public string Adress { get; set; }
        public List<Grade> Grades { get; set; }
    }
}