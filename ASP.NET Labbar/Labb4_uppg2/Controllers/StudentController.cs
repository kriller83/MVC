using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_uppg2.Models;

namespace Labb4_uppg2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details()
        {
            var student = new Student()
            {
                StudentId = 1,
                Address = "Kasten Rönnowsgatan 6",
                FirstName = "Kristian",
                LastName = "Ragnvaldsson",
                SocialSecuretyNumber = "830610",
                Grades = new List<Grade>()
                {
                    new Grade()
                    {
                        GradeId = 1,
                        CourseName = "ASP.NET MVC",
                        CourseGrade = "G"
                    },
                    new Grade()
                    {
                        GradeId = 2,
                        CourseName = "SharePoint",
                        CourseGrade = "VG"
                    },
                    new Grade()
                    {
                        GradeId = 3,
                        CourseName = "Entity Framework",
                        CourseGrade = "VG"
                    }
                }
            };
            Session["Student"] = student;
            return View(student);
        }

        public ActionResult ShowGrade()
        {
            var student = (Student) Session["Student"];
            return View(student.Grades);
        }
    }
}