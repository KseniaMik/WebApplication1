using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(string name, Genre g, DateTime d)
        {
            Name = name;
            ganr = g;
            Produce = d;
        }

        public virtual string Name { get; set; }

        public virtual Genre ganr { get; set; }

        public virtual DateTime Produce { get; set; }

        public long Id { get; set; }
       

    }
}


public enum Genre
{
    Drama,
    Comedy,
    Action,
    Horrow
}
