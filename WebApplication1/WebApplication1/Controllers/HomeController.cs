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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Image()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Comment(Comment comment)
        {
            var comments = Session["comments"] as List<Comment>;
            if (comments == null)
            {
                comments = new List<Comment>();
            }
            comments.Add(comment);
            Session["comments"] = comments;

            return RedirectToAction("Comments");
        }


        public ActionResult Comments()
        {
            var comments = Session["comments"] as List<Comment>;
            
           
          

            return View(comments);
        }


        public ActionResult Music()
        {
            var timemus = new Musictime();
            timemus.songtime = new DateTime(2008,01,26);
            return View(timemus);
        }
    }
}