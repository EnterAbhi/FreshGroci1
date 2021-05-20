using FreshGroci1.Data;
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
    public class ProductController : Controller
    {
        private readonly ProductDbContext _productData = null;
        public ProductController(ProductDbContext productData)
        {
            _productData = productData;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ViewResult> GetAllProduct()
        {
            var data = await _productData.tbl_Product.ToListAsync();

            return View(data);
        }

        public ViewResult GetProductById(int id)
        {
            var data = _productData.tbl_Product.Find(id);

            return View(data);
        }
    }
}
