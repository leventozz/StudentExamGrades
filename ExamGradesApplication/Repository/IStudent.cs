
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Repository
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents();
        string AddStudent(Student arg);
        string UpdateStudent(Student arg);
        string DeleteStudent(int id);
        Student SelectById(int id);
        Student GetStudentByIdentification(string iden);
    }
}
