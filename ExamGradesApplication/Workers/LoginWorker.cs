using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;
using ExamGradesApplication.Repository;

namespace ExamGradesApplication.Worker
{
    public class LoginWorker : ILoginWorker
    {
        private ITeacher _teacherService;
        private IStudent _studentService;
        public LoginWorker(ITeacher teacherService, IStudent studentService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
        }
        public bool IsLoginSuccess(LoginVM arg, int id)
        {
            if (id==1)
            {
                if (_teacherService.GetTeacherByIdentification(arg.IdentificationNumber) != null)
                {
                    if (arg.Password == _teacherService.GetTeacherByIdentification(arg.IdentificationNumber).TeacherPassword)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else return false;
                
            }
            else if (id == 2)
            {
                if (_studentService.GetStudentByIdentification(arg.IdentificationNumber) != null)
                {
                    if (arg.Password == _studentService.GetStudentByIdentification(arg.IdentificationNumber).StudentPassword)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }

        public PersonLoginVM LoginedPerson(string iden, int id)
        {
            if (id == 1)
            {
                try
                {
                    Teacher t = Context.Connection.Teachers.FirstOrDefault(x => x.TeacherIdentificationNumber == iden);
                    if (t != null)
                    {
                        return new PersonLoginVM()
                        {
                            Name = t.TeacherName,
                            LastName = t.TeacherLastName,
                            IdentificationNumber = t.TeacherIdentificationNumber,
                            LessonID = t.LessonID,
                            ID = t.TeacherID,
                            Job = "Öğretmen"
                        };
                    }
                    else
                        throw new Exception("Böyle bir öğretmen kaydı bulunamadı");
                }
                catch (Exception)
                {
                    throw new Exception("Böyle bir öğretmen kaydı bulunamadı");
                }
                
                
            }
            else if (id == 2)
            {
                Student s = Context.Connection.Students.FirstOrDefault(x => x.StudentIdentificationNumber == iden);
                try
                {
                    if (s!=null)
                    {
                        return new PersonLoginVM()
                        {
                            Name = s.StudentName,
                            LastName = s.StudentLastName,
                            IdentificationNumber = s.StudentIdentificationNumber,
                            ID = s.StudentID,
                            Job = "Öğrenci"
                        };
                    }
                    else
                        throw new Exception("Böyle bir öğrenci kaydı bulunamadı");
                }
                catch (Exception)
                {
                    throw new Exception("Böyle bir öğrenci kaydı bulunamadı");
                }
                
            }
            else
                return null;
        }
    }
}