using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Repository
{
    public interface IGrades
    {
        string SaveGrades(ExamGrade arg);
        IEnumerable<ExamGrade> GetGradeListByID(int id);
    }
}
