using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16032022_DurumYonetimi.Controllers
{
    public class Home3Controller : Controller
    {
        // GET: Home3
        public ActionResult Index()
        {
            //HttpContext.Cache.Add("ad", "istanbul", null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 10), System.Web.Caching.CacheItemPriority.Normal, null);
            //App-State ile aynıdır.Bilgisayarın raminde tutulduğu için bir ömrü vardır.

            HttpContext.Cache.Add("ad", "istanbul", null,new DateTime(2022,03,16,13,59,0),System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, CagirilacakMetot);

            return View();
        }

        public void CagirilacakMetot(string k,object b, System.Web.Caching.CacheItemRemovedReason a)
        {
            System.IO.File.WriteAllText(Server.MapPath("~/test.txt"), "cahche silindi");
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            HttpContext.Cache.Remove("ad");
            return View();
        }

    }
}