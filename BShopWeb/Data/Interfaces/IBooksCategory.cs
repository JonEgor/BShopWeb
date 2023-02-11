

using System;
using System.Collections.Generic;
using BShopWeb.Data.Models;

namespace BShopWeb.Data.Interfaces
{
    /// <summary>
    /// Возращает все функции с все категории  с модели Category
    /// </summary>



    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories { get; }  //Возрат списка 


    }
}
