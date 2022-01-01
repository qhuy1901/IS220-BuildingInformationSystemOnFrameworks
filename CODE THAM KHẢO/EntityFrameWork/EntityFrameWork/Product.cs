using System;
using System.Collections.Generic;

namespace EntityFrameWork
{
    public class Product
    {
        private int productId;
        private string name;
        private string provider;
        
        public int ProductId { set; get; }
        public string Name { set; get; }
        public string Provider { set; get; }
        //public List<Product> Products{ get; set; }
    }
}
