using DataAccess;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.DataAccess
{
    public class LessonAccess : IAccess<Lesson>
    {
        public IEnumerable<Lesson> GetAll()
        {
            return Context.Connection.Lessons.ToList();
        }
    }
}