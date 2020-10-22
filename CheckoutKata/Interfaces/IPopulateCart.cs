using System.Collections.Generic;
using KataLibrary;

namespace CheckoutKata
{
    public interface IPopulateCart
    {
        void ScanItems(ShoppingCartModel cart, Dictionary<string, ItemModel> Stock);
    }
}