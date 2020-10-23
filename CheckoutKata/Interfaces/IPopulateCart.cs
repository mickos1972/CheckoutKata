using System.Collections.Generic;
using KataLibrary;
using KataLibrary.Interfaces;

namespace CheckoutKata
{
    public interface IPopulateCart
    {
        void ScanItems(IShoppingCartModel cart, Dictionary<string, ItemModel> Stock);
    }
}