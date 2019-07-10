using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.App_Start
{
    public class Context
    {
        private static StudentInformationSystemDBEntities connection;

        public static StudentInformationSystemDBEntities Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new StudentInformationSystemDBEntities();
                }
                return connection;
            }
            set
            {
                connection = value;
            }
        }
    }
}