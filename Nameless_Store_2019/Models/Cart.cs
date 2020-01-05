using System;
using System.Data.Entity;

namespace Nameless_Store_2019
{
    public class Cart
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }

    public class CartDBContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
    }
}