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

        public void LetsGoToMorrisons(Dictionary<string, ItemModel> stock)
        {
            Console.WriteLine("Please select an item to add to the basket (A,B,C,D) press x to calculate total");

            _populateCart.ScanItems(_cart, stock);
            var total = _cart.GenerateTotal();

            Console.WriteLine($"The Total is : {total}");
        }
    }
}
