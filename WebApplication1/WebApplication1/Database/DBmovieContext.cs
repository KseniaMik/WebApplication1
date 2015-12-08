using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class DbMovieContext : DbContext
    {
        public DbMovieContext():base()
        {
        }

        public DbSet<Movie> Movies { get; set; }
   


    }
}