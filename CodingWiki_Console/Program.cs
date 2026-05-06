//using CodingWiki_DataAccess.Data;
//using CodingWiki_Model.Models;
//using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

////using (ApplicationDbContext context = new())
////{
////context.Database.EnsureCreated();
////if(context.Database.GetPendingMigrations().Count() > 0) 
////{
////context.Database.Migrate();
////}
////}
////AddBook();
////GetAllBook();
////GetBook();
////UpdateBook();
//DeleteBook();

//async void DeleteBook()
//{
//    using var context = new ApplicationDbContext();
//    var book = await context.Books.FindAsync(6);
//    context.Books.Remove(book);
//    await context.SaveChangesAsync();
    
//}


//async void UpdateBook()
//{
//    try
//    {
//        using var context = new ApplicationDbContext();
//        var books = await context.Books.Where(u=>u.Publisher_ID==1).ToListAsync();
//        foreach(var book in books)
//        {
//            book.Price += 5;
//        }
//        await context.SaveChangesAsync();
//    } catch (Exception e)
//    {
//    }
//}

//async void GetBook()
//{
//    try
//    {
//        using var context = new ApplicationDbContext();
//        //var book = context.Books.Find(6); //usato per l'id
//        //var book=context.Books.Single(u=>u.Publisher_ID==3); //Deve restiture un solo risultato, altrimenti lancia un'eccezione
//        //var books = context.Books.Where(u=>u.ISBN.Contains("12"));
//        //Console.WriteLine(book.Title + " - " + book.ISBN);

//        var books = await context.Books.OrderBy(u => u.Title).ToListAsync();
//        foreach (var book in books)
//        {
//            Console.WriteLine(book.Title + " - " + book.ISBN);
//        }
        
//    }
//    catch (Exception ex) { }
//}

//void GetAllBook()
//{
//    using var context = new ApplicationDbContext();
//    var books = context.Books.ToList();
//    foreach (var book in books) 
//    {
//        Console.WriteLine(book.Title+" - "+book.ISBN);
//    }
//}


//async void AddBook()
//{
//    Book book = new Book { Title = "New EF Core Book",ISBN="121212223",Price=10.93m,Publisher_ID=1};
//    using var context = new ApplicationDbContext();
//    var books =await context.Books.AddAsync(book);
//    context.SaveChangesAsync();
//}