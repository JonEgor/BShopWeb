using BShopWeb.Data.Interfaces;
using BShopWeb.Data.Models;

namespace BShopWeb.Data.mocks
{
    /// <summary>
    /// Рефлизация класса интерфейса IBooksCategory
    /// </summary>
    public class MockCategory : IBooksCategory // КЛАСС ДЛЯ РАБОТЫ С КАТЕГОРИЙ

    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                  /* First  */  new Category{ categoryName = "Художественная литература", desc = "Романы,Классическая литература,Исторические романы, и т.д"},
                   
                  /* Last  */ new Category{ categoryName = "Нехудожественная литература", desc = "Научно-популяраная литература,Биография.Мемуары, и т.д"},
                    
                    // new Category{ categoryName = " "} ( ДОПИСАТЬ КОТЕГОРИИ !!! ) 
                    
                };
            }
        }
    }
}
