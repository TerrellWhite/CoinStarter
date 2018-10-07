using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coinstarter.Controllers
{
    public class HomeController : Controller
    {
        static int run = 0;
        static readonly object lockObj = new object();
        static int UserEOS;
        static int numofProducts;

        public ActionResult Index()
        {
            ViewBag.EOS = UserEOS;
            ViewBag.Items = numofProducts;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TakeAway()
        {
            return View();
        }
        public ActionResult HowMany(int num)
        {
            lock (lockObj)
            {
                run++;
                UserEOS -= num * 10;
                numofProducts = num;
            }
            return RedirectToActionPermanent("Index");
        }
    }
}