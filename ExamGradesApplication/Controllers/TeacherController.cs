
using ExamGradesApplication.Models;
using ExamGradesApplication.Repository;
using ExamGradesApplication.Worker;
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
        IStudentListWorker _workerService;
        public TeacherController(IStudent studentService, IStudentListWorker workerService)
        {
            _studentService = studentService;
            _workerService = workerService;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(_workerService.GetStudentList());
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