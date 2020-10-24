using System.Collections.Generic;
using KataLibrary;
using KataLibrary.Interfaces;

namespace CheckoutKata
{
    public interface IPopulateCart
    {
        void ScanItems(IShoppingCart cart, Dictionary<string, ItemModel> Stock);
    }
}