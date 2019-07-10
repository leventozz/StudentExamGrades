﻿using ExamGradesApplication.DB;
using ExamGradesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Worker
{
    public interface IExamGradesWorker
    {
        ExamGradesVM GetExamsByID(int id);
        ExamGrade Mapper(ExamGradesVM arg); 
    }
}
