using DataAccess;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.DataAccess
{
    public class StudentAccess : IAccess<Student>
    {
        public void Create(Student arg)
        {
            Context.Connection.Students.Add(arg);
            Context.Connection.SaveChanges();
        }

        public int Delete(int argID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return Context.Connection.Students.ToList();
        }

        public Student Select(int argID)
        {
            return Context.Connection.Students.FirstOrDefault(x => x.StudentID == argID);
        }

        public int Update(Student arg)
        {
            throw new NotImplementedException();
        }
    }
}