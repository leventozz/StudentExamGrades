using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class StudentVM
    {
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentIdentificationNumber { get; set; }
        public int StudentPassword { get; set; }
    }
}