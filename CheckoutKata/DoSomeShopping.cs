using System;
using System.Collections.Generic;
using CheckoutKata.Interfaces;
using KataLibrary;
using KataLibrary.Interfaces;

namespace CheckoutKata
{
    public class DoSomeShopping : IDoSomeShopping
    {
        private readonly IPopulateCart _populateCart;
        private readonly IShoppingCart _cart;

        public DoSomeShopping(IPopulateCart populateCart, IShoppingCart cart)
        {
            _populateCart = populateCart;
            _cart = cart;
        }

        //This is where the program flow is controlled.
        public void LetsGoToMorrisons(Dictionary<string, ItemModel> stock, List<Rule> rules)
        {
            StandardMessages.PleaseEnterSelectionText();

            _populateCart.ScanItems(_cart, stock);
            var total = _cart.GenerateTotal(rules);

            StandardMessages.TotalMessage(total);
        }
    }
}
