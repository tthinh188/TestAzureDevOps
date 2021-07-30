using AzureAsg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureAsg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            testDBEntities te = new testDBEntities();
            var lst = te.Customers.ToList();
            return View(lst);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}