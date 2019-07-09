using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;

namespace ExamGradesApplication.Worker
{
    public class StudentListWorker : IStudentListWorker
    {
        public List<StudentListVM> GetStudentList()
        {
            List<Student> sList = Context.Connection.Students.ToList();
            List<StudentListVM> studentListVM = new List<StudentListVM>();
            foreach (var item in sList)
            {
                studentListVM.Add(new StudentListVM()
                {
                    StudentName = item.StudentName,
                    StudentLastName = item.StudentLastName,
                    StudentID = item.StudentID,
                    IdentificationNumber = item.StudentIdentificationNumber
                });
            }
            return studentListVM;
        }
    }
}