
using ExamGradesApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamGradesApplication.Controllers
{
    public class StudentController : Controller
    {
        IStudent _studentService;
        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(_studentService.GetStudents());
        }
    }
}