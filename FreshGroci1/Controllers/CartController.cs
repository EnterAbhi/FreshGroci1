using FreshGroci1.DataBaseContext;
using FreshGroci1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductDbContext _productData = null;
        public CartController(ProductDbContext productData)
        {
            _productData = productData;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int AddToCart(string id)
        {
            var count = _productData.tbl_Cart.Count();
            var data = _productData.tbl_Product.Find(int.Parse(id));
            var cartmodel = new CartModel()
            {
                Products = data,
                cartQuantity = count+1
            };

            _productData.tbl_Cart.Add(cartmodel);
            _productData.SaveChanges();
            return count+1;
        }
        
    }
}
