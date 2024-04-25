using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Client
    {
        public int CodeClie { get; set; }
        public string FirstNameClie { get; set; }
        public string LastNameClie { get; set; }
        public string AddressClie { get; set; }
        public int CodeCityClie { get; set; }
        public int PhoneCline { get; set; }
        public string EmailClie { get; set; }
        public string PasswordClie { get; set; }
        public string StatusClie { get; set; }
        public DateTime AddDateClie { get; set; } // תכונה מסוג תאריך

    }
}