using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using testTask1.Models;

namespace testTask1.Controllers
{
    public class HomeController : Controller
    {
        ProfileContext db = new ProfileContext();   
        public ActionResult Index()
        {
            IEnumerable<Profile> profile = db.Profile;
            ViewBag.Profile = profile;
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

     
    }
}