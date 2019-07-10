using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class GradeListVM
    {
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public int ExamGrade1 { get; set; }
        public int ExamGrade2 { get; set; }
    }
}