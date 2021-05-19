using FreshGroci1.Data;
using FreshGroci1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductData _productData = null;
        public ProductController()
        {
            _productData = new ProductData();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult GetAllProduct()
        {
            var data = _productData.GetAllProduct();

            return View(data);
        }

        public ViewResult GetProductById(int id)
        {
            var data = _productData.GetProductById(id);

            return View(data);
        }
    }
}
