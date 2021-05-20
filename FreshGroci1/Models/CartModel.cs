using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.Models
{
    public class CartModel
    {
        public int Id { get; set; }

        public ProductModel Products { get; set; }
        public int cartQuantity { get; set; }

    }
}
