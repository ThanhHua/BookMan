using BookMan.WebApp.Interface;
using BookMan.WebApp.Model;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookMan.WebApp.Pages
{
    public class BookModel : PageModel
    {
        public enum Action { Detail, Delete, Update, Create}
        private readonly IRepository _repository;
        public BookModel(IRepository repository) => _repository = repository;
        public Action Job { get; private set; }
        public Book Book { get; private set; }
        
        public void OnGet (int id)
        {
            Job = Action.Detail;
            Book = _repository.Get(id);
            ViewData["Title"] = Book == null ? "Book not found!" : $"Detail - {Book.Title}";
        }
    }
}
