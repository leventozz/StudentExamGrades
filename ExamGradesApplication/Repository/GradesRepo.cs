using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamGradesApplication.App_Start;
using ExamGradesApplication.DB;
using System.Data.Entity;

namespace ExamGradesApplication.Repository
{
    public class GradesRepo : IGrades
    {
        public IEnumerable<ExamGradeVM> GetGradeListByID(int id)
        {
            try
            {
                return Context.Connection.ExamGrades.Include(y => y.Student).Where(x => x.StudentID == id);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string SaveGrades(ExamGradeVM arg)
        {
            try
            {
                ExamGradeVM eg = Context.Connection.ExamGrades.FirstOrDefault(x => x.StudentID == arg.StudentID);
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