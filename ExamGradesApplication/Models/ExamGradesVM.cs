using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class ExamGradesVM
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public Nullable<int> ExamGrades1 { get; set; }
        public Nullable<int> ExamGrades2 { get; set; }
    }
}