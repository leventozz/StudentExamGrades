using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class ExamGrade
    {
        public int StudentID { get; set; }
        public int LessonID { get; set; }
        public int ExamGrades { get; set; }
    }
}