using System;
using System.Collections.Generic;

namespace KataLibrary.Interfaces
{
    public interface IShoppingCart
    {
        List<ItemModel> Items { get; set; }
        void AddItem(ItemModel item);
        decimal GenerateTotal(List<Rule> rules);
    }
}
