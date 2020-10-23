using System;
using System.Collections.Generic;
using KataLibrary;

namespace CheckoutKata
{
    public class PopulateCart : IPopulateCart
    {
        public void ScanItems(ShoppingCartModel cart, Dictionary<string, ItemModel> Stock)
        {
            //Read the input and populate the cart
            var input = "";

            //Console.WriteLine("Please select an item to add to the basket (A,B,C,D) press x to calculate total");

            while (input != "x")
            {
                input = Console.ReadLine().ToLower();

                //I know! dont judge me!
                if (input == "a" || input == "b" || input == "c" || input == "d")
                {
                    var item = Stock[input];

                    StandardMessages.YouHaveAdded(item);
                    cart.AddItem(item);
                }
            } 
        }
    }
}
