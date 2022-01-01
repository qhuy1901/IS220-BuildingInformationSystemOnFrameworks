using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Week7
{
    public class SinhVienContent : DbContext
    {
        private const string connectionString = "server=localhost;port=3307;database=quanlysinhvien;uid=root;password=";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(connectionString);
        }

        public DbSet<SinhVien> SinhVien { set; get; }

    }
}
