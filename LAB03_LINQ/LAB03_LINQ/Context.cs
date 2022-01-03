using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03_LINQ
{
    public class Context : DbContext
    {

        private const string connectionString = "server=localhost;port=3307;database=quanlybanhang;uid=root;password=";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(connectionString);
        }

        public DbSet<SanPham> SanPham { set; get; }

        public DbSet<HoaDon> HoaDon { set; get; }

        public DbSet<CTHD> CTHD { set; get; }
        public DbSet<KhachHang> KhachHang { set; get; }
    }
}
