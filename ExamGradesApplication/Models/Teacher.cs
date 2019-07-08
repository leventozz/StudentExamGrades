using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherLastName { get; set; }
        public int TeacherIdentificationNumber { get; set; }
        public int TeacherPassword { get; set; }
        public int LessonID { get; set; }
    }
}