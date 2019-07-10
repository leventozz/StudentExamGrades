using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExamGradesApplication.Repository;

namespace ExamGradesApplication.Worker
{
    public class ExamGradesWorker : IExamGradesWorker
    {
        IGrades _gradeService;
        IStudent _studentService;
        public ExamGradesWorker(IGrades gradeService, IStudent studentService)
        {
            _gradeService = gradeService;
            _studentService = studentService;
        }
        public ExamGradesVM GetExamsByID(int id, int lessonID)
        {
            var s = Context.Connection.ExamGrades.Include(y => y.Student).Include(z => z.Lesson).Where(x => x.StudentID == id).FirstOrDefault(y => y.LessonID == lessonID);
            return new ExamGradesVM()
            {
                StudentID = s.StudentID,
                StudentName = s.Student.StudentName,
                StudentLastName=s.Student.StudentLastName,
                LessonID = s.LessonID,
                LessonName=s.Lesson.LessonName,
                ExamGrades1=s.ExamGrades1,
                ExamGrades2=s.ExamGrades2
            };
        }

        public void SendExamGrades(ExamGradesVM arg)
        {
            ExamGrade eg = new ExamGrade();
            eg.StudentID = arg.StudentID;
            eg.LessonID = arg.LessonID;
            eg.ExamGrades1 = arg.ExamGrades1;
            eg.ExamGrades2 = arg.ExamGrades2;
            _gradeService.SaveGrades(eg);
        }
        

        public IEnumerable<ExamGradesVM> SendGradesList(PersonLoginVM arg)
        {
            List<ExamGradesVM> eList = new List<ExamGradesVM>();
            var temp =_studentService.GetStudentByIdentification(arg.IdentificationNumber);
            var temp2 =_gradeService.GetGradeListByID(temp.StudentID);
            foreach (var item in temp2)
            {
                eList.Add(new ExamGradesVM
                {
                    LessonName = item.Lesson.LessonName,
                    ExamGrades1 = item.ExamGrades1,
                    ExamGrades2 = item.ExamGrades2
                });
            }
            return eList;
        }
    }
}