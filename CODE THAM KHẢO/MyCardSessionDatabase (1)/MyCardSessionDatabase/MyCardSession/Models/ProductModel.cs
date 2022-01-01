using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;//thư viện cho mysql

namespace MyCardSession.Models
{
    public class ProductModel
    {
      /*  private List<Product> Products ;*/

        public string ConnectionString { get; set; }//biết thành viên

        public ProductModel(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Product> findAll()
        {
            List<Product> list = new List<Product>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Product", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            ProductName = reader["ProductName"].ToString(),
                            Price = Convert.ToInt32(reader["Price"].ToString()), 
                            ProductImage = reader["ProductImage"].ToString(),
                        });
                    }
                }

            }
            return list;
        }

        /*
        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "p01",
                    Name = "name 1",
                    Price = 4,
                    Photo = "flower1.jpeg"
                },
                new Product
                {
                    Id = "p02",
                    Name = "name 2",
                    Price = 2,
                    Photo = "flower2.jpeg"
                },
                new Product
                {
                    Id = "p03",
                    Name = "name 3",
                    Price = 8,
                    Photo = "flower3.jpeg"
                }
            };
        }
        */
        /*
        public List<Product> findAll()
        {
            return Products;
        }
        */
        //tìm sản phẩm có mã số bằng Id
        public Product find(int Id)
        {
            //Khoa kh = new Khoa("MK01","HTTT");
            Product pro = new Product();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from Product where ProductId=@ma";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ma", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    pro.ProductId = Convert.ToInt32(reader["ProductId"]);
                    pro.ProductName = reader["ProductName"].ToString();
                    pro.Price = Convert.ToInt32(reader["Price"].ToString());
                    pro.ProductImage = reader["ProductImage"].ToString();
                }
            }
            return (pro);
        }
        /*
        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }*/

    }
}
