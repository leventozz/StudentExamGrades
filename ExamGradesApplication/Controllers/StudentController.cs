using DataAccess;
using ExamGradesApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamGradesApplication.Controllers
{
    public class StudentController : Controller
    {
        private IAccess<StudentAccess> access;
        public StudentController(IAccess<StudentAccess> access)
        {
            this.access = access;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(this.access.GetAll());
        }
    }
}