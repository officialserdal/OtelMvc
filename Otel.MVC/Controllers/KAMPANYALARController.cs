using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel.MVC.Models.Entity;

namespace Otel.MVC.Controllers
{
    public class KAMPANYALARController : Controller
    {
        // GET: KAMPANYALAR
        OtelMvcEntities db = new OtelMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.Kampanya.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yonlendir(int id)
        {
            var yonlendır = db.Otel1.Find(id);
            return View(yonlendır);



        }

    }
}