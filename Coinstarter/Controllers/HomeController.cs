using Coinstarter.Models;
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
            
            //usersEntities ORM = new usersEntities();
            //ViewBag.User = ORM.users;
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
        public ActionResult TakeAway(/*string name*/)
        {
            //usersEntities ORM = new usersEntities();
            //user UserEdit = ORM.users.Find(name);
            //if (UserEdit == null)
            //{
            //    return RedirectToAction("AdminArtist");
            //}
            //ViewBag.User = UserEdit;
            return View();
        }
        public ActionResult HowMany(/*user Updateduser,*/ int num)
        {
            //usersEntities ORM = new usersEntities(); //need this is every operation that takes in information
            ////find the old record
            //user OldRecord = ORM.users.Find(Updateduser.name);
            //Updateduser.eos = OldRecord.eos - (num * 10);
            //Updateduser.items = OldRecord.items + num;
            //OldRecord.eos = Updateduser.eos;
            //OldRecord.items = Updateduser.items;
            //ORM.Entry(OldRecord).State = System.Data.Entity.EntityState.Modified;
            //ORM.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}