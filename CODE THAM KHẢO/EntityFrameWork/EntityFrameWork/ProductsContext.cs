using System;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameWork
{
    public class ProductsContext: DbContext
    {
        //private const string connectionString = "Data Source=localhost,1433;Initial Catalog=mydata;User ID=SA;Password=Password123";

        //private const string connectionString = "server=localhost;uid=root;password=;database=myproduct";

        private const string connectionString ="server=localhost;port=3307;database=myproduct;uid=root;password=";

        //internal object products;

        //private const string connectionString = "";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(connectionString);
        }

        public DbSet<Product> Product { set; get; }   // Bảng Product trong DataBase, <Product> tên lớp
        //public DbSet<>

    }
}
