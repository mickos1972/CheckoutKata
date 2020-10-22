using System.Collections.Generic;
using System.Linq;

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
            return Items.Sum(itemModel => itemModel.UnitPrice);
        }
    }
}