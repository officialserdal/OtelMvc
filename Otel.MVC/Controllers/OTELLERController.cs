using Otel.MVC.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Otel.MVC.Controllers
{
    public class OTELLERController : Controller
     
    {
        // GET: OTELLER
        OtelMvcEntities db = new OtelMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.Otel.ToList();

            return View(degerler);
           
        }
    }
}