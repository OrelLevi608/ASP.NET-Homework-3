using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class City
    {
        public int CodeCity { get; set; }
        public string NameCity { get; set; }
        public string StatusCity { get; set; }
        public DateTime AddDateCity { get; set; } // תכונה מסוג תאריך
    }
}