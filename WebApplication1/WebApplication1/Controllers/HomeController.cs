using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Database;
using WebApplication1.Models;
using WebApplication1.DAO;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]

        public ActionResult Index(Initializ init)
        {
            Response.Cookies["userName"].Value = init.kto;
          



            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            return View();
        }

        public List<Movie> GetAllFilms()
        {
            using (var db = new DbMovieContext())
            {
                return db.Movies.ToList();
            }
        }

        public List<Movie> GetAllFilms(int take)
        {
            using (var db = new DbMovieContext())
            {
                return db.Movies.OrderByDescending(x => x.Id).Take(take).ToList();
            }
        }

        public ActionResult Karusel()
        {
            var model = GetAllFilms(8);

            return View(model);
        }

        public List<Movie> GetAllFilmsOld()
        {
            List<Movie> movies = new List<Movie>();

            var film = new Movie("The man from U.N.C.L.E", Genre.Action, new DateTime(2007, 5, 18));

            movies.Add(film);

            film = new Movie
            {

                Produce = new DateTime(2009, 2, 15),
                ganr = Genre.Drama,
                Name = "The Ant-Man"
            };
            movies.Add(film);

            return movies;
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
            timemus.songtime = new DateTime(2008, 01, 26);
            return View(timemus);
        }

        public ActionResult Films()
        {
            var model = Addedfilm.AllFilms();
            return View(model);
        }

        public ActionResult FilterdFilms(Models.Filter filter)
        {

            var model = new List<Movie>();
            if (filter == null)
            {
                model = GetAllFilms();
            }
            else
            {
                model = GetAllFilms();
                model = model.Where(x => x.ganr == filter.genre).ToList();
                if (filter.year> 1800)
                {
                    var god = new DateTime(filter.year, 1, 1);
                    model = model.Where(x => x.Produce > god).ToList();
                }
             
            }

            return View("Films", model);
        }

        // фильтрация фильмов   
        public ActionResult Filters()
        {
            return View();
        }


        public ActionResult AddFilm()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddFilm(Movie movi)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    movi.Images = fileName;

                    var path = Path.Combine(Server.MapPath("~/Content/image/"), fileName);
                    file.SaveAs(path);
                }
            }

            Addedfilm.Saver(movi);
            return RedirectToAction("Films");

        }


        public ActionResult Remove(int IDdel)
        {
            Addedfilm.Delete(IDdel);
            return RedirectToAction("Films");
        }






    }
}