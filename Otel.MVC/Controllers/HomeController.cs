using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel.MVC.Models.Entity;


namespace Otel.MVC.Controllers
{
  
    public class HomeController : Controller
    {
        OtelMvcEntities db = new OtelMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.Otel.ToList();

            return View(degerler);
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