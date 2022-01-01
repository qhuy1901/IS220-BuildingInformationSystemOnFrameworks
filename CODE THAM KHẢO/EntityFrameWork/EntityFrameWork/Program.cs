using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork
{
    class Program
    {
        public static void ReadProducts()
        {
            using (var context = new ProductsContext())
            {
                // Lấy List các sản phẩm từ DB
                 var products = context.Product.ToList();
                 Console.WriteLine("Tất cả sản phẩm");
                 foreach (var product in products)
                 {
                     Console.WriteLine($"{product.ProductId,2} {product.Name,10} - {product.Provider}");
                 }
                 Console.WriteLine();
                 Console.WriteLine();
                 
                 /*
                var products = context.Product;//danh sách các sản phẩm, Product là tên lớp 
                
                var sanpham = products
                                .Where(p => p.ProductId == 2);
                
                foreach (var product in sanpham)
                {
                    Console.WriteLine($"{product.ProductId,2} {product.Name,10} - {product.Provider}");
                }
                */

                //Sử dụng LINQ trên DbSet (products)
                /*
                var products =  (from p in context.Product
                                      //where (p.ProductId == 1)
                                      select p
                                    ).ToList();
    
                Console.WriteLine("Sản phẩm CTY A");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductId,2} {product.Name,10} - {product.Provider}");
                }
                */
            }
        }
        public static  void InsertProduct()
        {
            using (var context = new ProductsContext())
            {
                Console.WriteLine("Đã lưu sản phẩm");
                // Dùng đối tượng DbSet để thêm
               /*  context.Product.Add(new Product
                {   ProductId = 4, 
                    Name = "Sản phẩm 4",
                    Provider = "Công ty 4"
                });
                */
                // Dùng context để thêm
                int id = 4;
                string name = "iphone 12";
                string pro = "Công ty Phương Nam";
                context.Product.Add(new Product()
                {
                    ProductId = id,
                    Name = name,
                    Provider = pro
                });

                // Thực hiện Insert vào DB các dữ liệu đã thêm.
                int rows = context.SaveChanges();
                Console.WriteLine($"Đã lưu {rows} sản phẩm");
                
            }
        }

        //Cập nhật dữ liệu có ProductId == id, và cập nhật tên mới là newName 
        public static void RenameProduct(int id, string newName)
        {
            using (var context = new ProductsContext())
            {

                // context.SetLogging();
                //dùng cú phá Query LINQ
                /*var product =  (from p in context.Product
                                     where (p.ProductId == id)
                                     select p
                                 )
                                .FirstOrDefault(); // Lấy  Product có ProductId = id 
                */

                //dung cú pháp method LINQ
                var product = context.Product
                               .Where(d => d.ProductId == id)
                               .FirstOrDefault();

                if (product != null)
                {
                    product.Name = newName;
                    //product.Provider = Provider; 
                    Console.WriteLine($"{product.ProductId,2} có tên mới = {product.Name,10}");
                    context.SaveChanges();  //Thi hành cập nhật
                }
            }
        }
        // Xóa sản phẩm có ProductID = id
        public static  void DeleteProduct(int id)
        {
            using (var context = new ProductsContext())
            {
                var product =  (from p in context.Product
                                     where (p.ProductId == id)
                                     select p
                                 )
                                .FirstOrDefault(); // Lấy  Product có  ID  chỉ  ra

                if (product != null)
                {
                    context.Remove(product);
                    Console.WriteLine($"Xóa {product.ProductId}");
                    context.SaveChanges();
                }
            }
        }
        static void Main(string[] args)
        {
            //InsertProduct();

            ReadProducts();

            /*RenameProduct(9, "Nokia 10");

            ReadProducts();
            
            DeleteProduct(9);
            ReadProducts();*/

        }
    }
}
