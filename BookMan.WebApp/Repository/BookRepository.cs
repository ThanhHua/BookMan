using System;
using System.Collections.Generic;
using System.Linq;

using BookMan.WebApp.Interface;
using BookMan.WebApp.Model;

namespace BookMan.WebApp.Repository
{
    public class BookRepository: IRepository
    {
        public HashSet<Book> Books { get; set; } = new HashSet<Book>
        {
            new Book {Id =1, Title = "ASP.NET Core for dummy", Publisher = "Apress", Year = 2018, Authors= "Donald Trump"},
            new Book {Id =2, Title ="Professional ASP.NET Core 3", Publisher= "Maining", Year = 2019, Authors= "Bill Clinton"},
            new Book {Id =3, Title = "ASP.NET Core Self learning", Publisher = "Wiley", Year= 2017, Authors="Barrack Obama"},
            new Book {Id =4, Title = "ASP.NET Core quick course", Publisher = "Linda", Authors = "George Bush"},
            new Book {Id =5,Title = "ASP.NET Core Video Course", Publisher = "Linda", Authors= "Vladimir Putin"}
        };
        public Book Get(int id) => Books.SingleOrDefault(b => b.Id == id);
    }

}
