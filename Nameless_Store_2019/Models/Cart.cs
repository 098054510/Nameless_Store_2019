using System;
using System.Data.Entity;

namespace MvcCart.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
    }

    public class CartDBContext : DbContext
    {
        public DbSet<Cart> Cartss { get; set; }
    }
}