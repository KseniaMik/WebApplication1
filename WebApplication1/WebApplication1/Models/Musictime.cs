using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Musictime
    {
        public DateTime songtime { get; set; }
        public TimeSpan differ { get
            {
                return DateTime.Now - songtime;                
            }
        }

    }
}