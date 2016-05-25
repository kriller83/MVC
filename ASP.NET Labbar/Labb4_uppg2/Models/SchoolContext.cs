using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Labb4_uppg2.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public SchoolContext() : base ("SchoolDb")
        {
            Database.SetInitializer<SchoolContext>(new ScoolContextInitializer());
        }
    }

    internal class ScoolContextInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var student = new Student()
            {
                StudentId = 1,
                Address = "Kasten Rönnowsgatan 6",
                FirstName = "Kristian",
                LastName = "Ragnvaldsson",
                SocialSecuretyNumber = "830610",
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        GradeId = 1,
                        CourseName = "ASP.NET MVC",
                        CourseGrade = "G"
                    },
                    new Grade
                    {
                        GradeId = 2,
                        CourseName = "SharePoint",
                        CourseGrade = "VG"
                    },
                    new Grade
                    {
                        GradeId = 3,
                        CourseName = "Entity Framework",
                        CourseGrade = "VG"
                    }
                }
            };
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}