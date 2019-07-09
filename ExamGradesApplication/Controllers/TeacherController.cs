
using ExamGradesApplication.Models;
using ExamGradesApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamGradesApplication.Controllers
{
    public class TeacherController : Controller
    {
        IStudent _studentService;
        public TeacherController(IStudent studentService)
        {
            _studentService = studentService;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(_studentService.GetStudents());
        }
        public ActionResult CreateStudent()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult CreateStudent(StudentVM arg)
        //{
        //    _studentService.AddStudent(arg);
        //    return RedirectToAction("Index");
        //}
        //public ActionResult AddGrades(int id)
        //{
        //    return View(_studentService.SelectById(id));
        //}
    }
}