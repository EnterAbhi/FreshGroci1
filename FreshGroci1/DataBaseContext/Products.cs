using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.DataBaseContext
{
    public class Products
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }
        public String Attributes { get; set; }
        public String ShortDescription { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }
        public String price { get; set; }
    }
}
