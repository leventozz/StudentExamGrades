using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;

namespace ExamGradesApplication.Repository
{
    public class StudentRepo : IStudent
    {
        public Student AddStudent(Student arg)
        {
            if (arg== null)
            {
                throw new ArgumentNullException("Nesne Hatalı");
            }
            Context.Connection.Students.Add(arg);
            Context.Connection.SaveChanges();
            return arg;
        }

        public bool DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            return Context.Connection.Students.ToList();
        }

        public Student SelectById(int id)
        {
            return Context.Connection.Students.FirstOrDefault(x => x.StudentID == id);
        }

        public bool UpdateStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}