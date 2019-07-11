using ExamGradesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGradesApplication.Worker
{
    public interface IStudentWorker
    {
        void AddStudent(StudentVM arg);
    }
}
