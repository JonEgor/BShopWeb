using BShopWeb.Data.Models;

namespace BShopWeb.Data.Interfaces
{
    public interface IAllBooks
    {
       IEnumerable<Book> Books { get;} // Возращает список ( перечисление ) 
       IEnumerable<Book> getFavBooks { get; set; } // 
       Book getObjectBook(int bookId);

    }
}
