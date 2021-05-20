using FreshGroci1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshGroci1.DataBaseContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }
        public DbSet<ProductModel> tbl_Product { get; set; }
        public DbSet<CartModel> tbl_Cart { get; set; }
    }
}
