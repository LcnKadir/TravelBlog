using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;


namespace TravelTripProje.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult MesajGonder()
        {
            return PartialView();

        }


        [HttpPost]
        public PartialViewResult MesajGonder(İletisim x)

        {
            c.İletisims.Add(x);
            c.SaveChanges();
            return PartialView("Index");


        }


    }
}