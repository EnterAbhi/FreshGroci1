using FreshGroci1.DataBaseContext;
using FreshGroci1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.Data
{
    public class ProductData
    {
        private readonly ProductDbContext _context = null;
        public ProductData(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductModel>> GetAllProduct()
        {
            var products = new List<ProductModel>();
            var allProduct = await _context.tbl_Product.ToListAsync();
            if (allProduct?.Any()==true)
            {
                foreach (var product in allProduct)
                {
                    products.Add(new ProductModel()
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Attributes = product.Attributes,
                        Image = product.Image,
                        ShortDescription = product.ShortDescription,
                        Description = product.Description,
                        price = product.price,
                        Category = product.Category
                    });

                }

            }
            return products;
        }
    }
}
