using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class StudentGradesVM
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
    }
}