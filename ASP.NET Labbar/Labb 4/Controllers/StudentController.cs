using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb_4.Models;

namespace Labb_4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _Create(int id)
        {
            Student student = new Student {StudentID = id};
            return PartialView(viewName: "_Create", model: student);
        }
        
        [HttpPost]
        public string _Create(int id, Student student)
        {
            return "A student was created";
        }
    }
}