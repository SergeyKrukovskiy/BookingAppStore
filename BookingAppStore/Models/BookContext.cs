using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookingAppStore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
    public class BookObInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л.Н.Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Преступление и наказание", Author = "Ф.М.Достоевский", Price = 300 });
            db.Books.Add(new Book { Name = "Мертвые души", Author = "И.С.Тургеньев", Price = 400 });
        }
    }
}