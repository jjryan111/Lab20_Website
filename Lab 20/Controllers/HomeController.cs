using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_20.Models;


namespace Lab_20.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About (Registration r)
        {

            ViewBag.Welcome = "Hello from me, " + r.name + ". Is "+ r.email+ " correct?";
            return View(r);

        }

    }

}