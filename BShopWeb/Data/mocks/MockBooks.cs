using BShopWeb.Data.Interfaces;
using BShopWeb.Data.Models;

namespace BShopWeb.Data.mocks
{
    /// <summary>
    /// Реализация интерфейса 
    /// </summary>
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory(); // Переменная указывает какой категории пренадлежит объект. 



        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book { name = "Война и мир том 1-2", 
                        shortDesc = "Лев Толстой",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 51, 
                        isFavourite = false, 
                        available = true,
                        Category =_categoryBooks.AllCategories.First()
                    }, // firsr означает что берёться первый элемент из списка в MockCategory 
                    
                    new Book { name = "Война и мир том 3-4",
                        shortDesc = "Лев Толстой",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 53,
                        isFavourite = true,
                        available = false,
                        Category =_categoryBooks.AllCategories.First()
                    },

                    new Book { name = "Отцы и дети",
                        shortDesc = "Иван Тургенев",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 34,
                        isFavourite = true,
                        available = true,
                        Category =_categoryBooks.AllCategories.First()
                    },


                    new Book { name = "Бесы",
                        shortDesc = "Федор Достоевский",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 55,
                        isFavourite = true,
                        available = true,
                        Category =_categoryBooks.AllCategories.First()
                    },



                    new Book { name = "Введение в психоанализ",
                        shortDesc = "Зигмунд Фрейд",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 50,
                        isFavourite = true,
                        available = true,
                        Category =_categoryBooks.AllCategories.Last()
                    },




                    new Book { name = "Никола Тесла",
                        shortDesc = "Михаил Ишков",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 40,
                        isFavourite = true,
                        available = true,
                        Category =_categoryBooks.AllCategories.Last()
                    },



                    new Book { name = "Вспомнить всё",
                        shortDesc = "Арнольд Шварценеггер ",
                        longDesc = "",
                        img = "/img/index.jpg",
                        price = 45,
                        isFavourite = true,
                        available = true,
                        Category =_categoryBooks.AllCategories.Last()
                    },





                    };
            }

        }
        
        
        
        
        
        
       
        














































        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
