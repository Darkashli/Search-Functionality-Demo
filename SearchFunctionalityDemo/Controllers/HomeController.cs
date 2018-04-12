using SearchFunctionalityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchFunctionalityDemo.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index(string searching)
        {
            if (string.IsNullOrEmpty(searching))
            {
                return View(db.Employees.ToList());
            }
            else
            {
                return View(db.Employees.Where(x => x.FirstName.StartsWith(searching)).ToList());
            }
        }

    }
}