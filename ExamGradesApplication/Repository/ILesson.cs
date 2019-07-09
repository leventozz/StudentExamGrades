
using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Repository
{
    public interface ILesson
    {
        IEnumerable<Lesson> GetLessons();
        Lesson AddLesson(Lesson arg);
        bool UpdateLesson(int id);
        bool DeleteLesson(int id);
        Lesson SelectById(int id);
    }
}
