
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
        IStudentListWorker _listWorkerService;
        IExamGradesWorker _gradesService;
        IStudentWorker _studentWorkerService;
        
        public TeacherController(IStudent studentService, IStudentListWorker workerService,IExamGradesWorker gradesService, IStudentWorker studentWorker)
        {
            _studentService = studentService;
            _listWorkerService = workerService;
            _gradesService = gradesService;
            _studentWorkerService = studentWorker;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(_listWorkerService.GetStudentList());
        }
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(StudentVM arg)
        {
            _studentWorkerService.AddStudent(arg);
            return RedirectToAction("Index");
        }

        public ActionResult AddGrades(int id)
        {
            var temp = (PersonLoginVM)Session["Person"];
            int lessonID = (int)temp.LessonID;
            if ((_gradesService.GetExamsByID(id, lessonID)!=null))
            {
                return View(_gradesService.GetExamsByID(id, lessonID));
            }
            else
            {
                TempData["msg"] = "<script>alert('Öğrenci bu dersi almamaktadır!');</script>";
                return RedirectToAction("Index","Teacher");
            }
            
        }
        [HttpPost]
        public ActionResult AddGrades(ExamGradesVM arg)
        {
            _gradesService.SendExamGrades(arg);
            return RedirectToAction("Index");
        }
    }
}