using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u=> u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<Book>().HasData(
                new Book { BookID=1,Title="Spider without Duty",ISBN="123B13",Price=10.99m},
                new Book { BookID = 2,Title = "Fortune of time",ISBN = "121B13",Price = 11.99m}
            );
            var bookList = new Book[]
            {
                new Book { BookID=3,Title="Fake Sunday",ISBN="77652",Price=20.99m},
                new Book { BookID=4,Title="Cookie Jar",ISBN="CC12B12",Price=25.99m},
                new Book { BookID=5,Title="Cloudy Forest",ISBN="90392B33",Price=40.99m},
            };
            modelBuilder.Entity<Book>().HasData(bookList);
        }
        
    }
}
