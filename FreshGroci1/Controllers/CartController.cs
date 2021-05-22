using FreshGroci1.DataBaseContext;
using FreshGroci1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public  IActionResult Index()
        {
            return View(_productData.tbl_Cart.ToList());
        }
        [HttpPost]
        public int AddToCart(string id)
        {
            var count = _productData.tbl_Cart.Count();
            var data = _productData.tbl_Product.Find(int.Parse(id));
            var cartmodel = new CartModel()
            {
                ProductId=data.Id,
                Name = data.Name,
                Image=data.Image,
                price=data.price,
                cartQuantity = count+1
            };

            _productData.tbl_Cart.Add(cartmodel);
            _productData.SaveChanges();
            return count+1;
        }
        public IActionResult DeleteById(int id)
        {

            var product = _productData.tbl_Cart.Where(x => x.ProductId == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            _productData.tbl_Cart.Remove(product);
            _productData.SaveChanges();
   
               return RedirectToAction("Index");
        }

    }
}
