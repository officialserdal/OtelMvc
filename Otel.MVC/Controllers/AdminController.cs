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
        OtelMvcEntities db = new OtelMvcEntities();

        public ActionResult Index()
        {
            var degerler = db.Otel11Set.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniOtel()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult YeniOtel(Otel11Set p)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniOtel");
            }
            db.Otel11Set.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}