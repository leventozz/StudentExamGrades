using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;

namespace ExamGradesApplication.Repository
{
    public class GradesRepo : IGrades
    {
        public string SaveGrades(ExamGrade arg)
        {
            try
            {
                ExamGrade eg = Context.Connection.ExamGrades.FirstOrDefault(x => x.StudentID == arg.StudentID);
                eg.ExamGrades1 = arg.ExamGrades1;
                eg.ExamGrades2 = arg.ExamGrades2;
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