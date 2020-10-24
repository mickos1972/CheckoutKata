using System.Collections.Generic;

namespace KataLibrary
{
    public interface IPopulateCart
    {
        void ScanItems(ShoppingCart cart, Dictionary<string, ItemModel> Stock);
    }
}