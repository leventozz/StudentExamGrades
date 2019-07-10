using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;
using ExamGradesApplication.Repository;

namespace ExamGradesApplication.Worker
{
    public class StudentWorker : IStudentWorker
    {
        IStudent _studentService;
        public StudentWorker(IStudent studentService)
        {
            _studentService = studentService;
        }
        public void AddStudent(StudentVM arg)
        {
            try
            {
                if (arg != null)
                {
                    Student s = new Student();
                    s.StudentName = arg.StudentName;
                    s.StudentLastName = arg.StudentLastName;
                    s.StudentIdentificationNumber = arg.StudentIdentificationNumber;
                    s.StudentPassword = arg.StudentPassword;
                    _studentService.AddStudent(s);
                }
                else
                    throw new Exception("Öğrenci eklemede hata oluştu!");
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci eklemede hata oluştu!");
            }
        }
    }
}