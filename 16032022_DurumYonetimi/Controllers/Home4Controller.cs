using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16032022_DurumYonetimi.Controllers
{
    public class Home4Controller : Controller
    {
        // GET: Home4
        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("username", "elif");

           // cookie.Expires = DateTime.Now.AddSeconds(2);

            HttpContext.Response.Cookies.Add(cookie);

            return View();
        }

        public ActionResult Index2()
        {
            if (HttpContext.Request.Cookies["username"] != null)
            {
                ViewBag.username = HttpContext.Request.Cookies["username"].Value;
            }
            else
                ViewBag.username = "Cookie Tanımlanmamış";
            return View();
        }

        public ActionResult Index3()
        {
            // HttpContext.Request.Cookies.Remove("username");

            HttpContext.Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(2);
            return View();
        }

    }
}