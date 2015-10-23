using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
 

        public ActionResult Image()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Music()
        {
            var timemus = new Musictime();
            timemus.songtime = new DateTime(2008,01,26);
            return View(timemus);
        }
    }
}