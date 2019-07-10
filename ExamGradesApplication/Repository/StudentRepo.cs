using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;

namespace ExamGradesApplication.Repository
{
    public class StudentRepo : IStudent
    {
        public string AddStudent(Student arg)
        {
            try
            {
                if (arg ==null)
                {
                    throw new Exception("Nesne hatalı");
                }
                Context.Connection.Students.Add(arg);
                Context.Connection.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteStudent(int id)
        {
            try
            {
                Student s = Context.Connection.Students.FirstOrDefault(x => x.StudentID == id);
                Context.Connection.ExamGrades.RemoveRange(Context.Connection.ExamGrades.Where(x => x.StudentID == s.StudentID));
                Context.Connection.Students.Remove(s);
                Context.Connection.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Student GetStudentByIdentification(string iden)
        {
            return Context.Connection.Students.FirstOrDefault(x => x.StudentIdentificationNumber == iden);
        }

        public IEnumerable<Student> GetStudents()
        {
            return Context.Connection.Students.ToList();
        }

        public Student SelectById(int id)
        {
             return Context.Connection.Students.FirstOrDefault(x => x.StudentID == id);
        }

        public string UpdateStudent(Student arg)
        {
            try
            {
                Student s = Context.Connection.Students.FirstOrDefault(x => x.StudentID == arg.StudentID);
                s.StudentName = arg.StudentName;
                s.StudentID = arg.StudentID;
                s.StudentLastName = arg.StudentLastName;
                s.StudentIdentificationNumber = arg.StudentIdentificationNumber;
                s.StudentPassword = arg.StudentPassword;
                Context.Connection.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}