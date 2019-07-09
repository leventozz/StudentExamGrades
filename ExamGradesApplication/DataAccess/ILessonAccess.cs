using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.DataAccess
{
    public interface ILessonAccess
    {
        void Create(Lesson arg);
        int Delete(int argID);
        int Update(Lesson arg);
        Lesson Select(int argID);
        IEnumerable<Lesson> GetAll();
    }
}
