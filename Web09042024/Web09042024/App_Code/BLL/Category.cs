using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Category
    {
        public int CodeCat { get; set; }
        public string NameCat { get; set; }
        public string DescriptionCat { get; set; }
        public string ImageNameCat { get; set; }
        public int ParentCodeCat { get; set; }
        public string StatusCat { get; set; }
        public DateTime AddDateCat { get; set; }
    }
}