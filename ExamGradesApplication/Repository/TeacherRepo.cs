using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;

namespace ExamGradesApplication.Repository
{
    public class TeacherRepo : ITeacher
    {
        public string AddTeacher(Teacher arg)
        {
            throw new NotImplementedException();
        }

        public string DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacherByIdentification(string iden)
        {
            return Context.Connection.Teachers.FirstOrDefault(x => x.TeacherIdentificationNumber == iden);
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            throw new NotImplementedException();
        }

        public Teacher SelectById(int id)
        {
            return Context.Connection.Teachers.FirstOrDefault(x => x.TeacherID == id);
        }

        public string UpdateTeacher(Teacher arg)
        {
            throw new NotImplementedException();
        }
    }
}