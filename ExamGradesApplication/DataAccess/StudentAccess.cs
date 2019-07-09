﻿using DataAccess;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.DataAccess
{
    public class StudentAccess : IAccess<Student>
    {
        public IEnumerable<Student> GetAll()
        {
            return Context.Connection.Students.ToList();
        }
    }
}