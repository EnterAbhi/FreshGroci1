using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.Models
{
    public class CartModel
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }

        public String price { get; set;}
        public int cartQuantity { get; set; }

    }
}
