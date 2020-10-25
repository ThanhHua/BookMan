using BookMan.WebApp.Interface;
using BookMan.WebApp.Model;
using Microsoft.AspNetCore.Mvc;
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

        public void OnGetDelete(int id)
        {
            Job = Action.Delete;
            Book = _repository.Get(id);
            ViewData["Title"] = Book == null ? "Book not found!" : $"Confirm deleting: {Book.Title}";
        }

        public IActionResult OnGeConfirm(int id)
        {
            _repository.Delete(id);
            return new RedirectToPageResult("index");
        }
    }
}
