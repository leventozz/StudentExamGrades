﻿using ExamGradesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.Worker
{
    public interface IStudentListWorker
    {
        List<StudentListVM> GetStudentList();
    }
}