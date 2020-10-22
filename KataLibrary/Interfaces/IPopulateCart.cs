using System.Collections.Generic;

namespace KataLibrary
{
    public interface IPopulateCart
    {
        void ScanItems(ShoppingCartModel cart, Dictionary<string, ItemModel> Stock);
    }
}