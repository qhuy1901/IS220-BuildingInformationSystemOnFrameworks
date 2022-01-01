using System;
namespace MyCardSession.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public Product()
        {
        }
    }
}
