using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Model;
using MyApp.DbOperation;

namespace MVCAppWithDb.Controllers
{
    EmployeeRepository Repository = null;
    public class HomeController : Controller
    {
        public HomeController()
        {
            Repository = new EmployeeRepository();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int id = Repository.AddEmployee(model);
                if(id >0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data Added Bro";
                }
            }
            return View();
        }
    }
}