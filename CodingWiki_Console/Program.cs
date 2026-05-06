using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//using (ApplicationDbContext context = new())
//{
//context.Database.EnsureCreated();
//if(context.Database.GetPendingMigrations().Count() > 0) 
//{
//context.Database.Migrate();
//}
//}
AddBook();
GetAllBook();
void GetAllBook()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();
    foreach (var book in books) 
    {
        Console.WriteLine(book.Title+" - "+book.ISBN);
    }
}


void AddBook()
{
    Book book = new Book { Title = "New EF Core Book",ISBN="121212223",Price=10.93m,Publisher_ID=1};
    using var context = new ApplicationDbContext();
    var books = context.Books.Add(book);
    context.SaveChanges();
}