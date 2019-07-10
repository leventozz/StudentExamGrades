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
            try
            {
                if (arg!=null)
                {
                    Context.Connection.Lessons.Add(arg);
                    return arg;
                }
                else
                    throw new Exception("Nesne gönderilirken hata oluştu");
            }
            catch (Exception)
            {
                throw new Exception("Nesne gönderilirken hata oluştu");
            }
            
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
            try
            {
                if (id != null)
                {
                    return Context.Connection.Lessons.FirstOrDefault(x => x.LessonID == id);
                }
                else
                    throw new Exception("ID hatalı");

            }
            catch (Exception ex)
            {

                throw new Exception("ID hatalı");
            }
            
        }

        public bool UpdateLesson(int id)
        {
            throw new NotImplementedException();
        }
    }
}