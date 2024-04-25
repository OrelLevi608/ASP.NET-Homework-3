using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Product
    {
        public int CodeProd { get; set; }
        public string NameProd { get; set; }
        public int PriceProd { get; set; }
        public string DescriptionProd { get; set; }
        public string NameImageProd { get; set; }
        public int CodeCategoryProd { get; set; }
        public string StatusProd { get; set; }
        public DateTime AddDateProd { get; set; }

    }
}