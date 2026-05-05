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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<FluentBookDetail> BookDetail_fluent { get; set; }
        public DbSet<FluentBook> Fluent_Books { get; set; }
        public DbSet<FluentAuthor> Fluent_Authors { get; set; }
        public DbSet<FluentPublisher> Fluent_Publisher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FluentBookDetail>().ToTable("Fluent_BookDetails");
            modelBuilder.Entity<FluentBookDetail>().Property(u=>u.NumberOfChapters).HasColumnName("NoOfChapters");
            modelBuilder.Entity<FluentBookDetail>().Property(u => u.NumberOfChapters).IsRequired();
            modelBuilder.Entity<FluentBookDetail>().HasKey(u => u.BookDetail_Id);
            modelBuilder.Entity<FluentBookDetail>().HasOne(b=>b.Book).WithOne(b=>b.BookDetail)
                .HasForeignKey<FluentBookDetail>(u=>u.Book_ID);

            modelBuilder.Entity<FluentBook>().Property(u => u.ISBN).HasMaxLength(50);
            modelBuilder.Entity<FluentBook>().Property(u => u.ISBN).IsRequired();
            modelBuilder.Entity<FluentBook>().HasKey(u => u.BookID);
            modelBuilder.Entity<FluentBook>().Ignore(u => u.PriceRange);

            modelBuilder.Entity<FluentAuthor>().HasKey(u => u.Author_Id);
            modelBuilder.Entity<FluentAuthor>().Property(u => u.FirstName).HasMaxLength(50);
            modelBuilder.Entity<FluentAuthor>().Property(u => u.FirstName).IsRequired();
            modelBuilder.Entity<FluentAuthor>().Property(u => u.LastName).IsRequired();
            modelBuilder.Entity<FluentAuthor>().Ignore(u => u.FullName);

            modelBuilder.Entity<FluentPublisher>().HasKey(u => u.Publisher_Id);
            modelBuilder.Entity<FluentPublisher>().Property(u => u.Name).IsRequired();




            modelBuilder.Entity<Book>().Property(u=> u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });

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
