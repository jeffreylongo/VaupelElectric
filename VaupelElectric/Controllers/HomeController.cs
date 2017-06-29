using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaupelElectric.Models;

namespace VaupelElectric.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
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

        public ActionResult EmailRequest()
        {
            return View();
        }

        public ActionResult ProcessRequest()
        {
            return View();
        }

        public ActionResult Prices()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }

        public ActionResult Services( )
        {

            //var services = db;
            //return View(services.ToList());
            return View();
        
        }
    }
}