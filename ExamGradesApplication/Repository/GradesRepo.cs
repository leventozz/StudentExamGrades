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
        public IEnumerable<ExamGrade> GetGradeListByID(int id)
        {
            try
            {
                if (id != null)
                {
                    return Context.Connection.ExamGrades.Include(y => y.Student).Where(x => x.StudentID == id);
                }
                else
                    throw new Exception("Öğrenci ID'si hatalı");
                
            }
            catch (Exception ex)
            {

                throw new Exception("Öğrenci ID'si hatalı");
            }
        }

        public string SaveGrades(ExamGrade arg)
        {
            try
            {
                if (arg!=null)
                {
                    ExamGrade eg = Context.Connection.ExamGrades.FirstOrDefault(x => x.StudentID == arg.StudentID);
                    eg.ExamGrades1 = arg.ExamGrades1;
                    eg.ExamGrades2 = arg.ExamGrades2;
                    Context.Connection.SaveChanges();
                    return "";
                }
                else
                    throw new Exception("Nesne gönderilirken hata oluştu");

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}