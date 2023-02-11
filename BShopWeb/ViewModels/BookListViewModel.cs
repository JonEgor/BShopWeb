using BShopWeb.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BShopWeb.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> allBooks { get; set; }
        public string bookCategory { get; set; }
    }


    






}
