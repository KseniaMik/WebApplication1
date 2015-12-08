using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class Addedfilm
    {
        public static void Saver(Movie add)
        {
            using (var db = new DbMovieContext())
            {
                 db.Movies.Add(add);
                db.SaveChanges();
            }
        }

        public static List<Movie> AllFilms()
        {
            using (var db = new DbMovieContext())
            {
                return db.Movies.ToList();
            }
        }

        public static void Delete(int del)
        {
            using (var db = new DbMovieContext())
            {
                var delmovie = db.Movies.First(x => x.Id == del);
                db.Movies.Remove(delmovie);
                db.SaveChanges();
            }
        }

        

    }
}