using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;

namespace ExamGradesApplication.Repository
{
    public class LessonRepo : ILesson
    {
        public Lesson AddLesson(Lesson arg)
        {
            Context.Connection.Lessons.Add(arg);
            return arg;
        }

        public bool DeleteLesson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lesson> GetLessons()
        {
            return Context.Connection.Lessons.ToList();
        }

        public Lesson SelectById(int id)
        {
            return Context.Connection.Lessons.FirstOrDefault(x => x.LessonID == id);
        }

        public bool UpdateLesson(int id)
        {
            throw new NotImplementedException();
        }
    }
}