using System.Collections.Generic;
using CheckoutKata.Interfaces;
using KataLibrary;

namespace CheckoutKata
{
    public class DoSomeShopping : IDoSomeShopping
    {
        private ShoppingCartModel _cart = new ShoppingCartModel();

        private readonly IPopulateCart _populateCart;

        public DoSomeShopping(IPopulateCart populateCart)
        {
            _populateCart = populateCart;
        }

        public void LetsGoToMorrisons(Dictionary<string, ItemModel> stock)
        {
            _populateCart.ScanItems(_cart, stock);
        }
    }
}
