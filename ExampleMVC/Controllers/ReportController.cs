using ExampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVC.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult NewUserForm()
        {
            return View("User");
        }

        [HttpPost]
        public ViewResult NewUserForm(UserModel usermodel)
        {
            if (ModelState.IsValid)
            {
                usermodel.Success = true;
                return View("UserSubmitConfirm", usermodel);
            }
            else
            {
                usermodel.Success = false;
                return View("User", usermodel);
            }
        }
    }
}