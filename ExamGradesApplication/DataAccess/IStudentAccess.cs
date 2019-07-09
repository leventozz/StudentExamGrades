using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IStudentAccess
    {
        void Create(Student arg);
        int Delete(int argID);
        int Update(Student arg);
        Student Select(int argID);
        IEnumerable<Student> GetAll();
    }
}
