using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.DataAccess
{
    public interface IAccess<T>
    {
        IEnumerable<T> GetAll();
    }
}