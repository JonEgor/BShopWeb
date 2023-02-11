using BShopWeb.Data.Interfaces;
using BShopWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BShopWeb.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;

        private readonly IBooksCategory _allCategory;

        public BooksController(IAllBooks iAllBooks,IBooksCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategory = iBooksCat; 
        }

        public ViewResult List()
        { 
            ViewBag.Title = "Страница с Книгами";
           BookListViewModel obj =new BookListViewModel();
           obj.allBooks = _allBooks.Books;
           obj.bookCategory = "Книги";
           return View(obj);
        }
    }
}
