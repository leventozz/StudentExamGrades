using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using ExamGradesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExamGradesApplication.Worker
{
    public class ExamGradesWorker : IExamGradesWorker
    {
        public ExamGradesVM GetExamsByID(int id)
        {
            var s = Context.Connection.ExamGrades.Include(y => y.Student).Include(z=>z.Lesson).FirstOrDefault(x => x.StudentID == id);
;
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

        public ExamGrade Mapper(ExamGradesVM arg)
        {
            ExamGrade eg = new ExamGrade();
            eg.StudentID = arg.StudentID;
            eg.LessonID = arg.LessonID;
            eg.ExamGrades1 = arg.ExamGrades1;
            eg.ExamGrades2 = arg.ExamGrades2;
            return eg;
        }
    }
}