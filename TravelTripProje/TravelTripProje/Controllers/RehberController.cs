using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        Content c = new Content();
        public ActionResult Index()
        {
            return View();
        }
    }
}