using ExamGradesApplication.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.DataAccess
{
    public class Cruder
    {
        IEnumerable<object> GetAll()
        {
            return Context.Connection.Students.ToList();
        }
    }
}