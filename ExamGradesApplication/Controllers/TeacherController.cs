
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
        IExamGradesWorker _gradesService;
        
        public TeacherController(IStudent studentService, IStudentListWorker workerService,IExamGradesWorker gradesService)
        {
            _studentService = studentService;
            _workerService = workerService;
            _gradesService = gradesService;
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

        public ActionResult AddGrades(int id)
        {
            return View(_gradesService.GetExamsByID(id));
        }
        [HttpPost]
        public ActionResult AddGrades(ExamGradesVM arg)
        {
            _gradesService.SendExamGrades(arg);
            return RedirectToAction("Index");
        }
    }
}