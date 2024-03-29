﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Models
{
    public class PersonLoginVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<int> LessonID { get; set; }
        public string IdentificationNumber { get; set; }
        public string Job { get; set; }
    }
}