using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel.MVC.Models.Entity;

namespace Otel.MVC.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        OtelMvcEntities db = new OtelMvcEntities();
        public ActionResult Index( )
        {
            var degerler = db.Otel11Set.ToList();

            return View(degerler);
          
        }
    }
}