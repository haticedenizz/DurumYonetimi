using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16032022_DurumYonetimi.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            HttpContext.Application["sayac"] = 1;
            //Her kullanıcı için aynıdır.Tektir.Globaldir.Uygulama Boyunca yaşar.
            return View();
        }

        public ActionResult Index2()
        {
            if (HttpContext.Application["sayac"] != null)
                ViewBag.sayac = HttpContext.Application["sayac"].ToString();
          

            return View();
        }

        public ActionResult Index3()
        {
            if(HttpContext.Application["sayac"]!=null)
            {
               int sayac = (int)HttpContext.Application["sayac"];

               sayac++;

               HttpContext.Application["sayac"] = sayac;

               return RedirectToAction("Index2");
            }
            else
               return RedirectToAction("Index");
         
        }

        public ActionResult Index4()
        {
           // HttpContext.Application.Clear();
           // HttpContext.Application.RemoveAll();
            HttpContext.Application.Remove("sayac");

            return RedirectToAction("Index2");
        }




    }
}