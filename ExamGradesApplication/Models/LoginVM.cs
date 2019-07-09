using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class LoginVM
    {
        public string IdentificationNumber { get; set; }
        public int Password { get; set; }
    }
}