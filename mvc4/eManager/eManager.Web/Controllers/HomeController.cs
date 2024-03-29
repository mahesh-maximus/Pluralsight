﻿using eManager.Dmoain;
using eManager.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db = new DepartmentDb();

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;
            return View(allDepartments);
        }

        public string TestAction()
        {
            return "TestAction";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
