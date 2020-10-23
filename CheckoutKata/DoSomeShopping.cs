using System;
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

        //This is where the program flow is controlled.
        public void LetsGoToMorrisons(Dictionary<string, ItemModel> stock)
        {
            StandardMessages.PleaseEnterSelectionText();

            _populateCart.ScanItems(_cart, stock);
            var total = _cart.GenerateTotal();

            StandardMessages.TotalMessage(total);
        }
    }
}
