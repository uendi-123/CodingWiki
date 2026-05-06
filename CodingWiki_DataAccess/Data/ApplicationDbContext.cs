using CodingWiki_DataAccess.FluentConfig;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookAuthorMap> BookAuthorMaps { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<FluentBookDetail> BookDetail_fluent { get; set; }
        public DbSet<FluentBook> Fluent_Books { get; set; }
        public DbSet<FluentAuthor> Fluent_Authors { get; set; }
        public DbSet<FluentPublisher> Fluent_Publisher { get; set; }
        public DbSet<FluentBookAuthorMap> Fluent_BookAuthorMap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;")
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name},LogLevel.Information );

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().Property(u=> u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });

            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorMapConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());

            modelBuilder.Entity<Book>().HasData(
                new Book { BookID=1,Title="Spider without Duty",ISBN="123B13",Price=10.99m,Publisher_ID=1},
                new Book { BookID = 2,Title = "Fortune of time",ISBN = "121B13",Price = 11.99m,Publisher_ID=1}
            );
            var bookList = new Book[]
            {
                new Book { BookID=3,Title="Fake Sunday",ISBN="77652",Price=20.99m,Publisher_ID=2},
                new Book { BookID=4,Title="Cookie Jar",ISBN="CC12B12",Price=25.99m,Publisher_ID=3},
                new Book { BookID=5,Title="Cloudy Forest",ISBN="90392B33",Price=40.99m,Publisher_ID=3},
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Publisher_Id=1,Name="Pub 1 Jimmy", Location="Chicago"},
                new Publisher { Publisher_Id=2,Name="Pub 2 John",Location="New York"},
                new Publisher { Publisher_Id=3,Name="Pub 3 Ben",Location="Hawaii"}
                );
        }
        
    }
}
