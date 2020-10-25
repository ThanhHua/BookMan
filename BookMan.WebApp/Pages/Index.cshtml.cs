
using System.Collections.Generic;

using BookMan.WebApp.Interface;
using BookMan.WebApp.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookMan.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;
        public HashSet<Book> Books => _repository.Books;
        public int Count => _repository.Books.Count;
        public IndexModel(IRepository repository) => _repository = repository;
    }
}
