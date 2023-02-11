namespace BShopWeb.Data.Models
{/// <summary>
/// ОПИСАНИЕ ТОВАРА ( конкретного товара)  
/// </summary>
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual  Category Category{ get; set; }

    }
}
