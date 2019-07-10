using Autofac;
using Autofac.Integration.Mvc;
using ExamGradesApplication.Repository;
using ExamGradesApplication.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExamGradesApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<StudentRepo>().As<IStudent>();
            builder.RegisterType<LoginWorker>().As<ILoginWorker>();
            builder.RegisterType<TeacherRepo>().As<ITeacher>();
            builder.RegisterType<StudentListWorker>().As<IStudentListWorker>();
            builder.RegisterType<ExamGradesWorker>().As<IExamGradesWorker>();
            builder.RegisterType<GradesRepo>().As<IGrades>();


            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
