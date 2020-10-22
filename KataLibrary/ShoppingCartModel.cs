using System.Collections.Generic;

namespace KataLibrary

{
    public class ShoppingCartModel
    {
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        public void AddItem(ItemModel item)
        {
            Items.Add(item);
        }

        public decimal GenerateTotal()
        {
            return 0;
        }
    }
}