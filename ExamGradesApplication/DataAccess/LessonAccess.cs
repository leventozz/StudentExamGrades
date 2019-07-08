using DataAccess;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.DataAccess
{
    public class LessonAccess : IAccess<DB.Lesson>
    {
        public void Create(Lesson arg)
        {
            Context.Connection.Lessons.Add(arg);
            Context.Connection.SaveChanges();
        }

        public int Delete(int argID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lesson> GetAll()
        {
            return Context.Connection.Lessons.ToList();
        }

        public Lesson Select(int argID)
        {
            return Context.Connection.Lessons.FirstOrDefault(x => x.LessonID == argID);
        }

        public int Update(Lesson arg)
        {
            throw new NotImplementedException();
        }
    }
}