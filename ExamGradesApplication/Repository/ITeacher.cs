using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Repository
{
    public interface ITeacher
    {
        IEnumerable<Teacher> GetTeachers();
        string AddTeacher(Teacher arg);
        string UpdateTeacher(Teacher arg);
        string DeleteTeacher(int id);
        Teacher SelectById(int id);
        Teacher GetTeacherByIdentification(string iden);
    }
}
