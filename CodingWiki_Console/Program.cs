using CodingWiki_DataAccess.Data;
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