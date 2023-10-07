using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel.MVC.Models.Entity;
    

namespace Otel.MVC.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        OtelMvcEntities otl = new OtelMvcEntities();
         
        public ActionResult Index()
        {
            var degerler = otl.Otel.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniOtel()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniOtel(OtelMvcEntities oten)
        {
            return View();



        }
    }
}