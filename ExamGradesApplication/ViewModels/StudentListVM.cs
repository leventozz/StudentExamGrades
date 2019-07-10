using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class StudentListVM
    {
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public int StudentID { get; set; }
        public string IdentificationNumber { get; set; }
    }
}