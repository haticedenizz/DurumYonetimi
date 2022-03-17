using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16032022_DurumYonetimi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            Session["deger"] = text;//Her kullanıcı için sunucu tarafında bir hafıza bölgesidir.
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            if (Session["deger"] != null)
                ViewBag.deger = Session["deger"].ToString();
            else
                ViewBag.deger = "Session bilgisi yok";

            return View();
        }

        public ActionResult Index3()
        {
            //Session.Clear();

            if (Session["deger"] != null)
                Session.Remove("deger");

            return View();
        }

    }
}