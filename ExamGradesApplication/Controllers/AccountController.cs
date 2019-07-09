using ExamGradesApplication.Models;
using ExamGradesApplication.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamGradesApplication.Controllers
{
    public class AccountController : Controller
    {
        ILoginWorker _loginService;
        public AccountController(ILoginWorker loginService)
        {
            _loginService = loginService;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginVM arg, int? id)
        {
            if (id == 1)
            {
                if (_loginService.IsLoginSuccess(arg, (int)id))
                {
                    Session.Add("Person", _loginService.LoginedPerson(arg.IdentificationNumber, (int)id));
                    return RedirectToAction("Index", "Teacher");
                }

            }
            else if (id == 2)
            {
                if (_loginService.IsLoginSuccess(arg, (int)id))
                {
                    Session.Add("Person", _loginService.LoginedPerson(arg.IdentificationNumber, (int)id));
                    return RedirectToAction("Index", "Student");
                }
            }
            ViewBag.ErrorMessage = "Giriş Başarısız";
            return Redirect("/Account/Index");
        }
    }
}