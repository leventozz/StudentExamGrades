using ExamGradesApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamGradesApplication.App_Start
{
    public class Context
    {
        private static StudentInformationSystemDBEntities1 connection;

        public static StudentInformationSystemDBEntities1 Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new StudentInformationSystemDBEntities1();
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