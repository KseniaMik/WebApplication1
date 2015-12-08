using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Helper
{
    public class Help
    {
        public static List<Genre> AllGenres
        {
            get
            {
                var a = new List<Genre>();
                a.Add(Genre.Action);
                a.Add(Genre.Comedy);
                a.Add(Genre.Drama);
                a.Add(Genre.Horrow);
                return a;
            }
        }
    }
}