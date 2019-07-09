using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Repository
{
    interface IStudent
    {
        IEnumerable<Student> GetStudents();
        Student AddStudent(Student arg);
        bool UpdateStudent(int id);
        bool DeleteStudent(int id);
        Student SelectById(int id);
    
    }
}
