using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        Blogyorum by = new Blogyorum();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderBy(x=> x.ID).Take(4).ToList(); // ID değerine göre en yeni yorumlardan eskilere doğru sıralama yapmanı sağlayacak. 
            return View(by);
        
        }

   
        public ActionResult BlogDetay(int id)
        {


            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            //var blogbul=c.Blogs.Where(x=> x.ID==id).ToList();
            return View(by);

        }

        [HttpGet] 
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();

        }

        [HttpPost] 
        public PartialViewResult YorumYap( Yorumlar y)
        {

            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();


        }



    }
}