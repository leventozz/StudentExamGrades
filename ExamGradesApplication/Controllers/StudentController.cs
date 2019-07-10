using ExamGradesApplication.Models;
using ExamGradesApplication.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamGradesApplication.Controllers
{
    public class StudentController : Controller
    {
        IExamGradesWorker _gradesService;
        public StudentController(IExamGradesWorker gradeService)
        {
            _gradesService = gradeService;
        }
        // GET: Student
        public ActionResult Index()
        {
            var temp = (PersonLoginVM)Session["Person"];
            return View(_gradesService.SendGradesList(temp));
        }
    }
}